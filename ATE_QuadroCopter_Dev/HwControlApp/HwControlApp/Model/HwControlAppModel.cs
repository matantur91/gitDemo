using AppInterfaces;
using DriversWrapper.PS;
using IniParser;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HwControlApp.Model
{
    public partial class HwControlAppModel : IAppModel, IDisposable
    {
        private static readonly object syncInstance = new object();
        private static readonly Dictionary<string, HwControlAppModel> InstancesDic = new Dictionary<string, HwControlAppModel>();

        public DriverPS DrvPS { get; private set; }
        public PowerSupplyStatus psStatus = new PowerSupplyStatus();

        public static HwControlAppModel GetInstance(string instanceName)
        {

            lock (syncInstance)
            {
                if (!InstancesDic.ContainsKey(instanceName))
                {
                    InstancesDic[instanceName] = new HwControlAppModel() { InstanceName = instanceName };
                }
            }
            return InstancesDic[instanceName];
        }

        public static HwControlAppModel GetInstance()
        {
            return GetInstance(string.Empty);
        }


        public event EventHandler<bool> SimulationModeEvent;
        public event EventHandler ModelDoneEvent;
        public event EventHandler UpdateUIEvent;
        public event EventHandler<PowerSupplyStatus> SetPSUIData;
        public string InstanceName { get; protected set; }
        public bool Simulation { get; protected set; }
        public bool AddOrRemoveDevices { get; protected set; }

        protected HwControlAppModel()
        {

        }

        public int InitAppModel(bool addOrRemoveDevices, string appConfig, string driversConfig)
        {

            AddOrRemoveDevices = addOrRemoveDevices;
            ReadParamsFromConfigFile(appConfig);
            SimulationModeEvent?.Invoke(this, Simulation);

            if (AddOrRemoveDevices)
            {

                //DriverPS.InitDriver(driversConfig);
                //DrvPS = DriverPS.GetInstance("Zup1");//create the DriverPS object   
                //DrvPS.AddDevice(driversConfig);// add the drivers configuration to DriverPS object
                //DrvPS.OutputPowerOn = false;// Turn on the power supply
                Devices.init(driversConfig, Constants.PSName, Constants.AIOName);
                //Add Drivers
                //DriverDIO.InitDriver(driversConfig);

                //Add Devices
                //DriverDIO.GetInstance("DIO1").AddDevice(driversConfig);

                
                //SetPSUIData.Invoke(this, psStatus);
                UpdateUI();
            }
            ModelDoneEvent?.Invoke(this, EventArgs.Empty);
            return 0;
        }


        private void ReadParamsFromConfigFile(string appConfig)
        {
            // parsing Interfaces.ini
            var section = string.IsNullOrEmpty(InstanceName) ? "TemplateApp.General" : $"HwControlApp.App.{InstanceName}";
            var parser = new FileIniDataParser();
            var iniData = parser.ReadFile(appConfig);
            if (iniData.Sections.ContainsSection(section) == false)
            {
                throw new IniParser.Exceptions.ParsingException($"Section {section} not found in the appConfig {appConfig}");
            }
            var interfaceSection = iniData[section];
            Simulation = interfaceSection.ContainsKey("bSimulation") && int.Parse(interfaceSection["bSimulation"], System.Globalization.NumberStyles.Any) != 0;

        }

        public int CloseAppModel()
        {
            Dispose();
            return 0;
        }

        public void Dispose()
        {
            if (AddOrRemoveDevices)
            {
                //DrvPS.OutputPowerOn = false;
                //DrvPS.Voltage_Programmed = 0;
                //DrvPS.CurrentLimit = 0;
                //Remove Devices
                //DriverDIO.GetInstance("DIO1").RemoveDevice();

                //Close Drivers
                //DriverDIO.CloseDriver(driversConfig);
            }
        }

        public PowerSupplyStatus GettingPowerSupplyData()
        {
            PowerSupplyStatus PwrStat = new PowerSupplyStatus();
            OperationResult OperRes = new OperationResult();

            OperRes = Devices.PS.GetPowerStatus();
            PwrStat = OperRes.Value;
            return PwrStat;
        }
        public async void UpdateUI()
        {

                while (true)
                {
                    psStatus = GettingPowerSupplyData();
                    SetPSUIData?.Invoke(this, psStatus);
                    //UpdateUIEvent?.Invoke(this, EventArgs.Empty);
                    await Task.Delay(1000);
                }
        }
    }
}
