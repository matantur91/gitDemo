using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using HwControlApp.Model;
using HwControlApp.UI;



namespace HwControlApp.Panel
{
    static partial class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var programArgs = ParseArguments(args);

                using (var appModel = HwControlAppModel.GetInstance(programArgs.InstanceName))
                {
                    
                    HwControlAppView appView = new HwControlAppView(appModel, true, false);
                    int status = appModel.InitAppModel(true, programArgs.InterfaceIniName, programArgs.DriversIniName);

                    if (status == 0)
                    {
                        Application.Run(appView);
                    }
                    else
                    {
                        throw new InvalidProgramException($"Failed to initialize model");
                    }
                }
            }
#if !DEBUG
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#else
            catch (Exception ex)
            {
                throw;
            }
#endif

        }

        private static ProgramArgs ParseArguments(string[] args)
        {
            string instanceName;
            string driversIniName;
            string interfaceIniName;
            if (args.Length == 3) //3 parameters instaceName Drivers.ini & Interfaces.ini
            {
                //Take the commands line args
                interfaceIniName = args[0];
                driversIniName = args[1];
                instanceName = args[2];
            }
            else
            {
                //take from App.Config 
                if (args.Length == 1)
                {
                    instanceName = args[0];
                }
                else
                {
                    instanceName = ConfigurationManager.AppSettings["Instance Name"];
                }
                interfaceIniName = ConfigurationManager.AppSettings["Interface INI Path"];
                driversIniName = ConfigurationManager.AppSettings["Drivers INI Path"];
            }

            if (instanceName == null)
            {
                throw new ArgumentNullException(nameof(instanceName));
            }
            if (interfaceIniName == null)
            {
                throw new ArgumentNullException(nameof(interfaceIniName));
            }
            if (driversIniName == null)
            {
                throw new ArgumentNullException(nameof(driversIniName));
            }

            if (!File.Exists(interfaceIniName))
            {
                throw new ArgumentNullException("the file interface INI file not found");
            }

            if (!File.Exists(driversIniName))
            {
                throw new ArgumentNullException("the file drivers INI file not found");
            }

            return new ProgramArgs(instanceName, driversIniName, interfaceIniName);
        }
    }
}

