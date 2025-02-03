using DriversWrapper.AIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwControlApp.Model
{
    class AIO : IAIO
    {
        private DriverAIO _drvAIO;
        public OperationResult OpRes = new OperationResult();
        public Dictionary<DateTime, double> flashlightVoltageAvgSample = new Dictionary<DateTime, double>();
        public Dictionary<DateTime, double> fireworkVoltageAvgSample = new Dictionary<DateTime, double>();

        //---constructors---

        public AIO(string driversConfig, string aioName)
        {
            DriverAIO.InitDriver(driversConfig);
            _drvAIO = DriverAIO.GetInstance(aioName);   //Create the Driver PS object.
            _drvAIO.AddDevice(driversConfig);         //Add the drivers configuration to driver PS object.
            
        }

        // Methods

        public OperationResult GetVoltAvg(AIChannels channel)
        {
            try
            {

                _drvAIO.InputChannels[channel].ConfigAIOChannel(DriversWrapper.AIO.ConfigChannels.RSE, Constants.AIOSamplesPerSec, Constants.AIOInBufferSize);
                //OpRes.Value = _drvAIO.InputChannels[channel].Buffer.Average();
                OpRes.Value = _drvAIO.InputChannels[channel].Buffer;
                List<double> lst = new List<double>();
                lst.AddRange(OpRes.Value);
                lst.Sort();
                lst.RemoveRange(OpRes.Value.Length - Constants.SampleBufferEdgeRemove, Constants.SampleBufferEdgeRemove);
                lst.RemoveRange(0, Constants.SampleBufferEdgeRemove);
                OpRes.Value = lst.Average();
                OpRes.IsSucceeded = Success.True;
                switch (channel)
                {
                    case AIChannels.CH0:
                        flashlightVoltageAvgSample.Add(DateTime.UtcNow, OpRes.Value);
                        break;
                    case AIChannels.CH1:
                        fireworkVoltageAvgSample.Add(DateTime.UtcNow, OpRes.Value);
                        break;
                    default:
                        throw new Exception("The channel does not exists !");
                }
                
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
        }

        public int GetCountOfVoltagesAbove(double voltageLimit)
        {
            //var q = from item in flashlightVoltageAvgSample
            //        where item.Value > voltageLimit
            //        select item;
            var q = flashlightVoltageAvgSample.Where(item => item.Value > voltageLimit);
            return q.Count();

        }

        //public KeyValuePair<DateTime, double> GetMaxVoltageAvg(AIChannels channel)
        public OperationResult GetMaxVoltageAvg(AIChannels channel)
        {
            double max = 0;
            DateTime t ;
            KeyValuePair<DateTime, double> temp;
            try
            {
                switch (channel)
                {
                    case AIChannels.CH0:
                        flashlightVoltageAvgSample.Values.Max();
                        max = flashlightVoltageAvgSample.Max(item => item.Value);
                        t = flashlightVoltageAvgSample.Where(item => item.Value == max).Select(item => item.Key).First();
                        temp = new KeyValuePair<DateTime, double>(t, max);
                        OpRes.Value = temp;
                        OpRes.IsSucceeded = Success.True;
                        break;
                    case AIChannels.CH1:
                        fireworkVoltageAvgSample.Values.Max();
                        max = fireworkVoltageAvgSample.Max(item => item.Value);
                        t = fireworkVoltageAvgSample.Where(item => item.Value == max).Select(item => item.Key).First();
                        temp = new KeyValuePair<DateTime, double>(t, max);
                        OpRes.Value = temp;
                        OpRes.IsSucceeded = Success.True;
                        break;

                    default:
                        throw new Exception("The channel does not exists !");

                }
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
            
        }
    }
}
