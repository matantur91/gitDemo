using DriversWrapper.PS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwControlApp.Model.OperationResult;



namespace HwControlApp.Model
{
    class PowerSupply : IPowerSupply
    {
        //private PowerStatus psStatus;
        public OperationResult OpRes = new OperationResult();
        private DriverPS _drvPS;

        
        //Cons't

        public PowerSupply(string driverConfig, string psName)
        {

            DriverPS.InitDriver(driverConfig);
            _drvPS = DriverPS.GetInstance(psName); //create the DriverPS object   
            _drvPS.AddDevice(driverConfig); // add the drivers configuration to DriverPS object
            _drvPS.OutputPowerOn = false; // Turn on the power supply
            //_drvPS.CurrentLimit = Constants.currentLimit;
            this.SetVoltage(Constants.startVoltage);
            this.SetCurrentLimit(Constants.currentLimit);
        }
        //Methods
        public OperationResult GetActualCurrent()
        {
            try
            {
                OpRes.Value = _drvPS.Current;
                OpRes.IsSucceeded = Success.True;
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
        }

        public OperationResult GetActualVoltage()
        {
            try
            {
                OpRes.Value = _drvPS.Voltage_Actual;
                OpRes.IsSucceeded = Success.True;
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
        }

        public OperationResult GetPowerStatus()
        {
            try
            {
                PowerSupplyStatus PwrStat = new PowerSupplyStatus();
                if (_drvPS.OutputPowerOn)
                {
                    PwrStat.OnOffStatus = PowerStatus.ON;
                    PwrStat.PresentVoltage = _drvPS.Voltage_Actual;
                }
                else
                    PwrStat.OnOffStatus = PowerStatus.OFF;
                OpRes.Value = PwrStat;
                OpRes.IsSucceeded = Success.True;

            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
        }
        
        public OperationResult GetVoltageProgrammed()
        {
            try
            {

                OpRes.Value = _drvPS.Voltage_Programmed ;
                OpRes.IsSucceeded = Success.True;
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex=ex;
            }
            return OpRes;
        }

        public OperationResult SetCurrentLimit(double newCurrentLimit)
        {
            try
            {
                _drvPS.CurrentLimit = newCurrentLimit;
                OpRes.IsSucceeded = Success.True;
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;
        }


        public OperationResult SetPowerONOFF(PowerStatus state)
        {
            try
            {
                switch (state)
                {
                    case PowerStatus.OFF:
                        _drvPS.OutputPowerOn = false;
                        break;
                    case PowerStatus.ON:
                        _drvPS.OutputPowerOn = true;
                        break;
                }
                OpRes.IsSucceeded = Success.True;
                //if (state == PowerStatus.ON)
                //    _drvPS.OutputPowerOn = true;
                //else
                //    _drvPS.OutputPowerOn = false;

                //OpRes.IsSucceeded = Success.True;
            }
            catch(Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }       
            
            return OpRes;
        }

        public OperationResult SetVoltage(double newVoltage)
        {
            try
            {
                _drvPS.Voltage_Programmed = newVoltage;
                OpRes.IsSucceeded = Success.True;
            }
            catch (Exception ex)
            {
                OpRes.IsSucceeded = Success.False;
                OpRes.Ex = ex;
            }
            return OpRes;

        }

        public OperationResult GetCurrentLimit()
        {
            try
            {
                OpRes.Value = _drvPS.CurrentLimit;
                OpRes.IsSucceeded = Success.True;
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
