namespace HwControlApp.UI
{
    partial class HwControlAppView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HwControlAppView));
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.pictureBoxRunMode = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainStatusBar = new System.Windows.Forms.StatusBar();
            this.statusPanel = new System.Windows.Forms.StatusBarPanel();
            this.datetimePanel = new System.Windows.Forms.StatusBarPanel();
            this.ControlPanel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeaderInterface = new System.Windows.Forms.Label();
            this.panelHelpAbout = new System.Windows.Forms.Panel();
            this.lblRunMode = new System.Windows.Forms.Label();
            this.labelHelpAbout = new System.Windows.Forms.Label();
            this.mainAppPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ShowData_button = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SetCurrentLimit_textBox = new System.Windows.Forms.TextBox();
            this.SetVoltage_textBox = new System.Windows.Forms.TextBox();
            this.SetCurrentLimit = new System.Windows.Forms.Button();
            this.SetVoltage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivePS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunMode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimePanel)).BeginInit();
            this.ControlPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelHelpAbout.SuspendLayout();
            this.mainAppPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Image = global::HwControlApp.Properties.Resources.Help_30px;
            this.pictureBoxAbout.Location = new System.Drawing.Point(73, 8);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxAbout.TabIndex = 35;
            this.pictureBoxAbout.TabStop = false;
            this.pictureBoxAbout.Click += new System.EventHandler(this.pictureBoxAbout_Click);
            // 
            // pictureBoxRunMode
            // 
            this.pictureBoxRunMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxRunMode.Image = global::HwControlApp.Properties.Resources.runMode;
            this.pictureBoxRunMode.Location = new System.Drawing.Point(17, 7);
            this.pictureBoxRunMode.Name = "pictureBoxRunMode";
            this.pictureBoxRunMode.Size = new System.Drawing.Size(39, 34);
            this.pictureBoxRunMode.TabIndex = 36;
            this.pictureBoxRunMode.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Simulation";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.ToolTipText = "Driver run in simulation mode";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainStatusBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ControlPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainAppPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 445);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Location = new System.Drawing.Point(3, 428);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusPanel,
            this.datetimePanel});
            this.mainStatusBar.ShowPanels = true;
            this.mainStatusBar.Size = new System.Drawing.Size(692, 14);
            this.mainStatusBar.TabIndex = 56;
            // 
            // statusPanel
            // 
            this.statusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Text = "Application started. No action yet.";
            this.statusPanel.ToolTipText = "Last Activity";
            this.statusPanel.Width = 636;
            // 
            // datetimePanel
            // 
            this.datetimePanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.datetimePanel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
            this.datetimePanel.Name = "datetimePanel";
            this.datetimePanel.Text = "2020";
            this.datetimePanel.ToolTipText = "DateTime: 02/12/2014 00:00:00";
            this.datetimePanel.Width = 39;
            // 
            // ControlPanel2
            // 
            this.ControlPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel2.BackgroundImage = global::HwControlApp.Properties.Resources.Header;
            this.ControlPanel2.Controls.Add(this.tableLayoutPanel2);
            this.ControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.ControlPanel2.Name = "ControlPanel2";
            this.ControlPanel2.Size = new System.Drawing.Size(698, 60);
            this.ControlPanel2.TabIndex = 55;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.labelHeaderInterface, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelHelpAbout, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 60);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // labelHeaderInterface
            // 
            this.labelHeaderInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderInterface.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderInterface.Location = new System.Drawing.Point(123, 0);
            this.labelHeaderInterface.Name = "labelHeaderInterface";
            this.labelHeaderInterface.Size = new System.Drawing.Size(452, 60);
            this.labelHeaderInterface.TabIndex = 31;
            this.labelHeaderInterface.Text = "PS Driver";
            this.labelHeaderInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHelpAbout
            // 
            this.panelHelpAbout.Controls.Add(this.pictureBoxRunMode);
            this.panelHelpAbout.Controls.Add(this.pictureBoxAbout);
            this.panelHelpAbout.Controls.Add(this.lblRunMode);
            this.panelHelpAbout.Controls.Add(this.labelHelpAbout);
            this.panelHelpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelpAbout.Location = new System.Drawing.Point(578, 0);
            this.panelHelpAbout.Margin = new System.Windows.Forms.Padding(0);
            this.panelHelpAbout.Name = "panelHelpAbout";
            this.panelHelpAbout.Size = new System.Drawing.Size(120, 60);
            this.panelHelpAbout.TabIndex = 27;
            // 
            // lblRunMode
            // 
            this.lblRunMode.Location = new System.Drawing.Point(9, 42);
            this.lblRunMode.Name = "lblRunMode";
            this.lblRunMode.Size = new System.Drawing.Size(57, 12);
            this.lblRunMode.TabIndex = 34;
            this.lblRunMode.Text = "Run";
            this.lblRunMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHelpAbout
            // 
            this.labelHelpAbout.Location = new System.Drawing.Point(70, 42);
            this.labelHelpAbout.Name = "labelHelpAbout";
            this.labelHelpAbout.Size = new System.Drawing.Size(37, 13);
            this.labelHelpAbout.TabIndex = 31;
            this.labelHelpAbout.Text = "About";
            this.labelHelpAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainAppPanel
            // 
            this.mainAppPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainAppPanel.Controls.Add(this.label9);
            this.mainAppPanel.Controls.Add(this.textBox1);
            this.mainAppPanel.Controls.Add(this.label8);
            this.mainAppPanel.Controls.Add(this.label7);
            this.mainAppPanel.Controls.Add(this.label6);
            this.mainAppPanel.Controls.Add(this.textBox8);
            this.mainAppPanel.Controls.Add(this.label5);
            this.mainAppPanel.Controls.Add(this.textBox7);
            this.mainAppPanel.Controls.Add(this.label4);
            this.mainAppPanel.Controls.Add(this.textBox6);
            this.mainAppPanel.Controls.Add(this.label2);
            this.mainAppPanel.Controls.Add(this.textBox5);
            this.mainAppPanel.Controls.Add(this.ShowData_button);
            this.mainAppPanel.Controls.Add(this.textBox4);
            this.mainAppPanel.Controls.Add(this.button4);
            this.mainAppPanel.Controls.Add(this.textBox3);
            this.mainAppPanel.Controls.Add(this.button3);
            this.mainAppPanel.Controls.Add(this.label3);
            this.mainAppPanel.Controls.Add(this.SetCurrentLimit_textBox);
            this.mainAppPanel.Controls.Add(this.SetVoltage_textBox);
            this.mainAppPanel.Controls.Add(this.SetCurrentLimit);
            this.mainAppPanel.Controls.Add(this.SetVoltage);
            this.mainAppPanel.Controls.Add(this.label1);
            this.mainAppPanel.Controls.Add(this.ActivePS);
            this.mainAppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAppPanel.Location = new System.Drawing.Point(0, 60);
            this.mainAppPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainAppPanel.Name = "mainAppPanel";
            this.mainAppPanel.Size = new System.Drawing.Size(698, 365);
            this.mainAppPanel.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "PS Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(229, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(229, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Firework voltage";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(570, 303);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 20);
            this.textBox8.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Flashlight voltage";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(570, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(84, 20);
            this.textBox7.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "PS Current Limit";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(570, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(84, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "PS Voltage";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(570, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 20);
            this.textBox5.TabIndex = 13;
            // 
            // ShowData_button
            // 
            this.ShowData_button.Location = new System.Drawing.Point(466, 153);
            this.ShowData_button.Name = "ShowData_button";
            this.ShowData_button.Size = new System.Drawing.Size(188, 32);
            this.ShowData_button.TabIndex = 12;
            this.ShowData_button.Text = "Show Data";
            this.ShowData_button.UseVisualStyleBackColor = true;
            this.ShowData_button.Click += new System.EventHandler(this.ShowData_button_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Firework voltage";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(248, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Flashlight voltage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Set Current Limit";
            // 
            // SetCurrentLimit_textBox
            // 
            this.SetCurrentLimit_textBox.Location = new System.Drawing.Point(146, 153);
            this.SetCurrentLimit_textBox.Name = "SetCurrentLimit_textBox";
            this.SetCurrentLimit_textBox.Size = new System.Drawing.Size(80, 20);
            this.SetCurrentLimit_textBox.TabIndex = 6;
            this.SetCurrentLimit_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetCurrentLimit_textBox_KeyPress);
            // 
            // SetVoltage_textBox
            // 
            this.SetVoltage_textBox.Location = new System.Drawing.Point(146, 66);
            this.SetVoltage_textBox.Name = "SetVoltage_textBox";
            this.SetVoltage_textBox.Size = new System.Drawing.Size(80, 20);
            this.SetVoltage_textBox.TabIndex = 5;
            this.SetVoltage_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetVoltage_textBox_KeyPress);
            // 
            // SetCurrentLimit
            // 
            this.SetCurrentLimit.Location = new System.Drawing.Point(248, 131);
            this.SetCurrentLimit.Name = "SetCurrentLimit";
            this.SetCurrentLimit.Size = new System.Drawing.Size(137, 42);
            this.SetCurrentLimit.TabIndex = 4;
            this.SetCurrentLimit.Text = "Set";
            this.SetCurrentLimit.UseVisualStyleBackColor = true;
            this.SetCurrentLimit.Click += new System.EventHandler(this.SetCurrentLimit_Click);
            // 
            // SetVoltage
            // 
            this.SetVoltage.Location = new System.Drawing.Point(248, 44);
            this.SetVoltage.Name = "SetVoltage";
            this.SetVoltage.Size = new System.Drawing.Size(137, 42);
            this.SetVoltage.TabIndex = 3;
            this.SetVoltage.Text = "Set";
            this.SetVoltage.UseVisualStyleBackColor = true;
            this.SetVoltage.Click += new System.EventHandler(this.SetVoltage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set Voltage";
            // 
            // ActivePS
            // 
            this.ActivePS.AutoSize = true;
            this.ActivePS.Location = new System.Drawing.Point(473, 97);
            this.ActivePS.Name = "ActivePS";
            this.ActivePS.Size = new System.Drawing.Size(102, 17);
            this.ActivePS.TabIndex = 0;
            this.ActivePS.Text = "Output ON/OFF";
            this.ActivePS.UseVisualStyleBackColor = true;
            this.ActivePS.CheckedChanged += new System.EventHandler(this.ActivePS_checkBox);
            // 
            // HwControlAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HwControlAppView";
            this.Text = "HwControlAppView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HwControlAppView_FormClosing);
            this.Load += new System.EventHandler(this.HwControlAppView_Load);
            this.Shown += new System.EventHandler(this.HwControlAppView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunMode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetimePanel)).EndInit();
            this.ControlPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelHelpAbout.ResumeLayout(false);
            this.mainAppPanel.ResumeLayout(false);
            this.mainAppPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusBar mainStatusBar;
        private System.Windows.Forms.StatusBarPanel statusPanel;
        private System.Windows.Forms.Panel ControlPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelHeaderInterface;
        private System.Windows.Forms.Panel panelHelpAbout;
        private System.Windows.Forms.PictureBox pictureBoxRunMode;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Label lblRunMode;
        private System.Windows.Forms.Label labelHelpAbout;
        private System.Windows.Forms.StatusBarPanel datetimePanel;
        private System.Windows.Forms.Panel mainAppPanel;
        private System.Windows.Forms.CheckBox ActivePS;
        private System.Windows.Forms.TextBox SetCurrentLimit_textBox;
        private System.Windows.Forms.TextBox SetVoltage_textBox;
        private System.Windows.Forms.Button SetCurrentLimit;
        private System.Windows.Forms.Button SetVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ShowData_button;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}