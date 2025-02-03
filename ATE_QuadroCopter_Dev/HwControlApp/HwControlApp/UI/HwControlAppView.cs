using AppInterfaces;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using HwControlApp.Model;
using HwControlApp.Properties;
using System.Threading;
using static HwControlApp.Model.PowerSupply;
using static HwControlApp.Model.OperationResult;
using System.Threading.Tasks;
using DriversWrapper.AIO;
using System.Collections.Generic;

namespace HwControlApp.UI
{
    public partial class HwControlAppView : Form, IAppView
    {
        public HwControlAppModel AppModel { get; }
        private AppWindowState windowState;
        public bool MinimizeOnCloseButton { get; }
        protected bool VisibleWindow { get; }

        public OperationResult opRes = new OperationResult();

        public AppWindowState AppWndState
        {
            get { return windowState; }
            set
            {
                windowState = value;
                this.InvokeIfNeeded(() =>
                {
                    Visible = (value == AppWindowState.Normal || value == AppWindowState.Maximized || value == AppWindowState.Minimized);
                });
            }
        }

        public HwControlAppView(HwControlAppModel model, bool visibleWindow, bool minimizeOnCloseButton)
        {
            InitializeComponent();
            AppModel = model;
            MinimizeOnCloseButton = minimizeOnCloseButton;
            VisibleWindow = visibleWindow;
            labelHeaderInterface.Text = AppModel.InstanceName;
            RegisterAllEvents();
            

        }

        protected void RegisterAllEvents()
        {
            /*add all events you need to know about in your view*/
            AppModel.SimulationModeEvent += SetSimulationMode;
            AppModel.ModelDoneEvent += AppModel_ModelDoneEvent;
            AppModel.SetPSUIData += GettingPowerSupplyStatus;

        }

        protected void UnregisterAllEvents()
        {
            /*remove all events you need to know about in your view*/
            AppModel.SimulationModeEvent -= SetSimulationMode;
            AppModel.ModelDoneEvent -= AppModel_ModelDoneEvent;
            AppModel.SetPSUIData -= GettingPowerSupplyStatus;
        }

        private void AppModel_ModelDoneEvent(object sender, EventArgs e)
        {

        }


        private void HwControlAppView_Load(object sender, EventArgs e)
        {
            this.InvokeIfNeeded(() =>
            {
                this.Text += $"     Version: {FileVersionInfo.GetVersionInfo(Assembly.GetAssembly(this.GetType()).Location).FileVersion}";
                datetimePanel.Text = DateTime.Now.Date.ToString().Split(' ').First();
            });

        }

        private void HwControlAppView_Shown(object sender, EventArgs e) => AppWndState = (VisibleWindow ? AppWindowState.Normal : AppWindowState.Hidden);

        private void HwControlAppView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MinimizeOnCloseButton;
            if (MinimizeOnCloseButton)
            {
                AppWndState = AppWindowState.Hidden;
            }
            else
            {
                UnregisterAllEvents();
            }
        }

        private void pictureBoxAbout_Click(object sender, EventArgs e) => Utils.ShowAboutBox();

        protected void SetSimulationMode(object sender, bool SimMode)
        {
            this.InvokeIfNeeded(() =>
            {
                pictureBoxRunMode.Image = (SimMode == true) ? Resources.simulationMode : Resources.runMode;
                lblRunMode.Text = (SimMode == true) ? Resources.SimulatorModeStr : Resources.RunModeStr;
                lblRunMode.ForeColor = (SimMode == true) ? Color.Red : Color.Black;
            });
        }

        #region panel control

        private void SetPower(Model.PowerStatus pStat)
        {

            Devices.PS.SetPowerONOFF(pStat);
            Thread.Sleep(200);
            if (pStat == Model.PowerStatus.ON)
            {
                opRes = Devices.PS.GetVoltageProgrammed();
                SetVoltage_textBox.Text = opRes.Value.ToString();
                opRes = Devices.PS.GetCurrentLimit();
                SetCurrentLimit_textBox.Text = opRes.Value.ToString();
            }
            //AppModel.GettingPowerSupplyData();

        }

        protected void GettingPowerSupplyStatus(object sender, PowerSupplyStatus e)
        {
            this.InvokeIfNeeded(() =>
            {
                textBox1.Text = e.OnOffStatus.ToString();
                textBox5.Text = e.PresentVoltage.ToString() + "V";
                opRes = Devices.PS.GetActualCurrent();
                textBox6.Text = opRes.Value.ToString();
                opRes = Devices.AIO.GetVoltAvg(AIChannels.CH0);
                textBox7.Text = opRes.Value.ToString();
                opRes = Devices.AIO.GetVoltAvg(AIChannels.CH1);
                textBox8.Text = opRes.Value.ToString();
                
            });
        }


        private void ShowData_button_Click(object sender, EventArgs e)
        {
            opRes = Devices.PS.GetPowerStatus();
            textBox1.Text = opRes.Value.ToString();
            opRes = Devices.PS.GetActualVoltage();
            textBox5.Text = opRes.Value.ToString();
            opRes = Devices.PS.GetCurrentLimit();
            textBox6.Text = opRes.Value.ToString();
            opRes = Devices.AIO.GetVoltAvg(AIChannels.CH0);
            textBox7.Text = opRes.Value.ToString();
            opRes = Devices.AIO.GetVoltAvg(AIChannels.CH1);
            textBox8.Text = opRes.Value.ToString();
        }


        private void SetCurrentLimit_Click(object sender, EventArgs e)
        {
            double current = double.Parse(SetCurrentLimit_textBox.Text);
            Devices.PS.SetCurrentLimit(current);
        }

        private void SetVoltage_Click(object sender, EventArgs e)
        {
            double voltage = double.Parse(SetVoltage_textBox.Text);
            Devices.PS.SetVoltage(voltage);
        }

        private void ActivePS_checkBox(object sender, EventArgs e)
        {
            if (ActivePS.Checked)
            {
                SetPower(Model.PowerStatus.ON);
            }

            else
            {
                SetPower(Model.PowerStatus.OFF);
            }
        }

        private void SetVoltage_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Devices.PS.SetVoltage(double.Parse(SetVoltage_textBox.Text));
        }

        private void SetCurrentLimit_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Devices.PS.SetCurrentLimit(double.Parse(SetCurrentLimit_textBox.Text));
        }

    }
}
#endregion panel control