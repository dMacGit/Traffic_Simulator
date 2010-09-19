using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    partial class MainGuiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGuiForm));
            this.TrafficSimulatorMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TrafficSimulatorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrafficSimulatorMenu
            // 
            this.TrafficSimulatorMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TrafficSimulatorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.TrafficSimulatorMenu.Location = new System.Drawing.Point(0, 0);
            this.TrafficSimulatorMenu.Name = "TrafficSimulatorMenu";
            this.TrafficSimulatorMenu.Size = new System.Drawing.Size(1108, 24);
            this.TrafficSimulatorMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designToolStripMenuItem,
            this.simulationToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::Traffic_Simulator.Properties.Resources.File_Icon_30x30;
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.A)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Image = global::Traffic_Simulator.Properties.Resources.design_Icon;
            this.designToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D)));
            this.designToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.designToolStripMenuItem.Text = "Design";
            this.designToolStripMenuItem.Click += new System.EventHandler(this.MainGuiForm_Load);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.Image = global::Traffic_Simulator.Properties.Resources.simulation_Icon;
            this.simulationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.simulationToolStripMenuItem.Text = "Simulation";
            this.simulationToolStripMenuItem.Click += new System.EventHandler(this.MainGuiForm_Load);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designToolStripMenuItem1,
            this.simulationToolStripMenuItem1});
            this.openToolStripMenuItem.Image = global::Traffic_Simulator.Properties.Resources.open_Icon;
            this.openToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // designToolStripMenuItem1
            // 
            this.designToolStripMenuItem1.Image = global::Traffic_Simulator.Properties.Resources.design_Icon;
            this.designToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.designToolStripMenuItem1.Name = "designToolStripMenuItem1";
            this.designToolStripMenuItem1.Size = new System.Drawing.Size(166, 36);
            this.designToolStripMenuItem1.Text = "Design";
            // 
            // simulationToolStripMenuItem1
            // 
            this.simulationToolStripMenuItem1.Image = global::Traffic_Simulator.Properties.Resources.simulation_Icon;
            this.simulationToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.simulationToolStripMenuItem1.Name = "simulationToolStripMenuItem1";
            this.simulationToolStripMenuItem1.Size = new System.Drawing.Size(166, 36);
            this.simulationToolStripMenuItem1.Text = "Simulation";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designToolStripMenuItem2,
            this.simulationToolStripMenuItem2});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // designToolStripMenuItem2
            // 
            this.designToolStripMenuItem2.Name = "designToolStripMenuItem2";
            this.designToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.designToolStripMenuItem2.Text = "Design";
            // 
            // simulationToolStripMenuItem2
            // 
            this.simulationToolStripMenuItem2.Name = "simulationToolStripMenuItem2";
            this.simulationToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.simulationToolStripMenuItem2.Text = "Simulation";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconsToolStripMenuItem,
            this.layToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            // 
            // iconsToolStripMenuItem
            // 
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iconsToolStripMenuItem.Text = "Icons";
            // 
            // layToolStripMenuItem
            // 
            this.layToolStripMenuItem.Name = "layToolStripMenuItem";
            this.layToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layToolStripMenuItem.Text = "Layout";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem4,
            this.designToolStripMenuItem3});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // simulationToolStripMenuItem4
            // 
            this.simulationToolStripMenuItem4.Name = "simulationToolStripMenuItem4";
            this.simulationToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.simulationToolStripMenuItem4.Text = "Simulation";
            // 
            // designToolStripMenuItem3
            // 
            this.designToolStripMenuItem3.Name = "designToolStripMenuItem3";
            this.designToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.designToolStripMenuItem3.Text = "Design";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem3});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // simulationToolStripMenuItem3
            // 
            this.simulationToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.startToolStripMenuItem});
            this.simulationToolStripMenuItem3.Name = "simulationToolStripMenuItem3";
            this.simulationToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.simulationToolStripMenuItem3.Text = "Simulation";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // MainGuiForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1108, 522);
            this.Controls.Add(this.TrafficSimulatorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.TrafficSimulatorMenu;
            this.Name = "MainGuiForm";
            this.Text = "Traffic Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainGuiForm_Load);
            this.TrafficSimulatorMenu.ResumeLayout(false);
            this.TrafficSimulatorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip TrafficSimulatorMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem designToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem designToolStripMenuItem1;
        private ToolStripMenuItem simulationToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem designToolStripMenuItem2;
        private ToolStripMenuItem simulationToolStripMenuItem2;
        private ToolStripMenuItem iconsToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem4;
        private ToolStripMenuItem controlsToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem3;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem layToolStripMenuItem;
        private ToolStripMenuItem designToolStripMenuItem3;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}

