namespace Traffic_Simulator
{
    partial class DesignGuiForm
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
            this.worldMap = new System.Windows.Forms.Panel();
            this.mapSplitContainer = new System.Windows.Forms.SplitContainer();
            this.miniMapPanel = new System.Windows.Forms.Panel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.componentPalletGroup = new System.Windows.Forms.GroupBox();
            this.MwayLanes = new System.Windows.Forms.GroupBox();
            this.twoLaneMwayText = new System.Windows.Forms.Label();
            this.threeLaneMwayText = new System.Windows.Forms.Label();
            this.singleRoadText = new System.Windows.Forms.Label();
            this.MwayRamps = new System.Windows.Forms.GroupBox();
            this.onRampText = new System.Windows.Forms.Label();
            this.offRampText = new System.Windows.Forms.Label();
            this.singleRoadIcon = new System.Windows.Forms.PictureBox();
            this.twoLaneMwayIcon = new System.Windows.Forms.PictureBox();
            this.threeLaneMwayIcon = new System.Windows.Forms.PictureBox();
            this.onRampIcon = new System.Windows.Forms.PictureBox();
            this.offRampIcon = new System.Windows.Forms.PictureBox();
            this.mapSplitContainer.Panel1.SuspendLayout();
            this.mapSplitContainer.Panel2.SuspendLayout();
            this.mapSplitContainer.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.componentPalletGroup.SuspendLayout();
            this.MwayLanes.SuspendLayout();
            this.MwayRamps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleRoadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoLaneMwayIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeLaneMwayIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onRampIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offRampIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // worldMap
            // 
            this.worldMap.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.worldMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.worldMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldMap.Location = new System.Drawing.Point(0, 0);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(885, 485);
            this.worldMap.TabIndex = 3;
            // 
            // mapSplitContainer
            // 
            this.mapSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapSplitContainer.IsSplitterFixed = true;
            this.mapSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mapSplitContainer.Name = "mapSplitContainer";
            // 
            // mapSplitContainer.Panel1
            // 
            this.mapSplitContainer.Panel1.Controls.Add(this.miniMapPanel);
            // 
            // mapSplitContainer.Panel2
            // 
            this.mapSplitContainer.Panel2.Controls.Add(this.worldMap);
            this.mapSplitContainer.Size = new System.Drawing.Size(1378, 489);
            this.mapSplitContainer.SplitterDistance = 485;
            this.mapSplitContainer.TabIndex = 0;
            // 
            // miniMapPanel
            // 
            this.miniMapPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.miniMapPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miniMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miniMapPanel.Location = new System.Drawing.Point(0, 0);
            this.miniMapPanel.Name = "miniMapPanel";
            this.miniMapPanel.Padding = new System.Windows.Forms.Padding(5);
            this.miniMapPanel.Size = new System.Drawing.Size(481, 485);
            this.miniMapPanel.TabIndex = 0;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mapSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.componentPalletGroup);
            this.mainSplitContainer.Size = new System.Drawing.Size(1378, 780);
            this.mainSplitContainer.SplitterDistance = 489;
            this.mainSplitContainer.TabIndex = 4;
            // 
            // componentPalletGroup
            // 
            this.componentPalletGroup.Controls.Add(this.MwayLanes);
            this.componentPalletGroup.Controls.Add(this.MwayRamps);
            this.componentPalletGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentPalletGroup.Location = new System.Drawing.Point(0, 0);
            this.componentPalletGroup.Name = "componentPalletGroup";
            this.componentPalletGroup.Padding = new System.Windows.Forms.Padding(5);
            this.componentPalletGroup.Size = new System.Drawing.Size(1374, 283);
            this.componentPalletGroup.TabIndex = 0;
            this.componentPalletGroup.TabStop = false;
            this.componentPalletGroup.Text = "Units";
            // 
            // MwayLanes
            // 
            this.MwayLanes.Controls.Add(this.twoLaneMwayText);
            this.MwayLanes.Controls.Add(this.threeLaneMwayText);
            this.MwayLanes.Controls.Add(this.singleRoadText);
            this.MwayLanes.Controls.Add(this.singleRoadIcon);
            this.MwayLanes.Controls.Add(this.twoLaneMwayIcon);
            this.MwayLanes.Controls.Add(this.threeLaneMwayIcon);
            this.MwayLanes.Location = new System.Drawing.Point(322, 21);
            this.MwayLanes.Name = "MwayLanes";
            this.MwayLanes.Size = new System.Drawing.Size(421, 145);
            this.MwayLanes.TabIndex = 6;
            this.MwayLanes.TabStop = false;
            this.MwayLanes.Text = "Road Size";
            // 
            // twoLaneMwayText
            // 
            this.twoLaneMwayText.AutoSize = true;
            this.twoLaneMwayText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.twoLaneMwayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.twoLaneMwayText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.twoLaneMwayText.Location = new System.Drawing.Point(295, 101);
            this.twoLaneMwayText.Name = "twoLaneMwayText";
            this.twoLaneMwayText.Size = new System.Drawing.Size(77, 17);
            this.twoLaneMwayText.TabIndex = 7;
            this.twoLaneMwayText.Text = "Two Lanes";
            // 
            // threeLaneMwayText
            // 
            this.threeLaneMwayText.AutoSize = true;
            this.threeLaneMwayText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.threeLaneMwayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.threeLaneMwayText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.threeLaneMwayText.Location = new System.Drawing.Point(295, 37);
            this.threeLaneMwayText.Name = "threeLaneMwayText";
            this.threeLaneMwayText.Size = new System.Drawing.Size(89, 17);
            this.threeLaneMwayText.TabIndex = 6;
            this.threeLaneMwayText.Text = "Three Lanes";
            // 
            // singleRoadText
            // 
            this.singleRoadText.AutoSize = true;
            this.singleRoadText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.singleRoadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.singleRoadText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.singleRoadText.Location = new System.Drawing.Point(91, 37);
            this.singleRoadText.Name = "singleRoadText";
            this.singleRoadText.Size = new System.Drawing.Size(85, 17);
            this.singleRoadText.TabIndex = 5;
            this.singleRoadText.Text = "Single Road";
            // 
            // MwayRamps
            // 
            this.MwayRamps.Controls.Add(this.onRampText);
            this.MwayRamps.Controls.Add(this.offRampText);
            this.MwayRamps.Controls.Add(this.onRampIcon);
            this.MwayRamps.Controls.Add(this.offRampIcon);
            this.MwayRamps.Location = new System.Drawing.Point(21, 21);
            this.MwayRamps.Name = "MwayRamps";
            this.MwayRamps.Size = new System.Drawing.Size(181, 145);
            this.MwayRamps.TabIndex = 5;
            this.MwayRamps.TabStop = false;
            this.MwayRamps.Text = "Ramps";
            // 
            // onRampText
            // 
            this.onRampText.AutoSize = true;
            this.onRampText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.onRampText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.onRampText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.onRampText.Location = new System.Drawing.Point(90, 101);
            this.onRampText.Name = "onRampText";
            this.onRampText.Size = new System.Drawing.Size(68, 17);
            this.onRampText.TabIndex = 3;
            this.onRampText.Text = "On Ramp";
            // 
            // offRampText
            // 
            this.offRampText.AutoSize = true;
            this.offRampText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.offRampText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.offRampText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.offRampText.Location = new System.Drawing.Point(90, 37);
            this.offRampText.Name = "offRampText";
            this.offRampText.Size = new System.Drawing.Size(68, 17);
            this.offRampText.TabIndex = 2;
            this.offRampText.Text = "Off Ramp";
            // 
            // singleRoadIcon
            // 
            this.singleRoadIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.singleRoadIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singleRoadIcon.Image = global::Traffic_Simulator.Properties.Resources.SingleRoadIconB;
            this.singleRoadIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.singleRoadIcon.Location = new System.Drawing.Point(21, 19);
            this.singleRoadIcon.Name = "singleRoadIcon";
            this.singleRoadIcon.Size = new System.Drawing.Size(50, 50);
            this.singleRoadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.singleRoadIcon.TabIndex = 2;
            this.singleRoadIcon.TabStop = false;
            this.singleRoadIcon.Click += new System.EventHandler(this.singleRoadClicked);
            // 
            // twoLaneMwayIcon
            // 
            this.twoLaneMwayIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoLaneMwayIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoLaneMwayIcon.Image = global::Traffic_Simulator.Properties.Resources.TwoLaneHwayIcon;
            this.twoLaneMwayIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.twoLaneMwayIcon.Location = new System.Drawing.Point(221, 85);
            this.twoLaneMwayIcon.Name = "twoLaneMwayIcon";
            this.twoLaneMwayIcon.Size = new System.Drawing.Size(50, 50);
            this.twoLaneMwayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoLaneMwayIcon.TabIndex = 3;
            this.twoLaneMwayIcon.TabStop = false;
            this.twoLaneMwayIcon.Click += new System.EventHandler(this.twoLaneMwayClicked);
            // 
            // threeLaneMwayIcon
            // 
            this.threeLaneMwayIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeLaneMwayIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.threeLaneMwayIcon.Image = global::Traffic_Simulator.Properties.Resources.ThreeLaneHwayIcon;
            this.threeLaneMwayIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.threeLaneMwayIcon.Location = new System.Drawing.Point(221, 19);
            this.threeLaneMwayIcon.Name = "threeLaneMwayIcon";
            this.threeLaneMwayIcon.Size = new System.Drawing.Size(50, 50);
            this.threeLaneMwayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threeLaneMwayIcon.TabIndex = 4;
            this.threeLaneMwayIcon.TabStop = false;
            this.threeLaneMwayIcon.Click += new System.EventHandler(this.threeLaneMwayClicked);
            // 
            // onRampIcon
            // 
            this.onRampIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onRampIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onRampIcon.Image = global::Traffic_Simulator.Properties.Resources.MwayOnRampIcon;
            this.onRampIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.onRampIcon.Location = new System.Drawing.Point(17, 85);
            this.onRampIcon.Name = "onRampIcon";
            this.onRampIcon.Size = new System.Drawing.Size(50, 50);
            this.onRampIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onRampIcon.TabIndex = 1;
            this.onRampIcon.TabStop = false;
            this.onRampIcon.Click += new System.EventHandler(this.onRampClicked);
            // 
            // offRampIcon
            // 
            this.offRampIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offRampIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offRampIcon.Image = global::Traffic_Simulator.Properties.Resources.MwayOffRampIcon;
            this.offRampIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.offRampIcon.Location = new System.Drawing.Point(17, 19);
            this.offRampIcon.Name = "offRampIcon";
            this.offRampIcon.Size = new System.Drawing.Size(50, 50);
            this.offRampIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offRampIcon.TabIndex = 0;
            this.offRampIcon.TabStop = false;
            this.offRampIcon.Click += new System.EventHandler(this.offRampClicked);
            // 
            // DesignGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.ControlBox = false;
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "DesignGuiForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "newDesign";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DesignGuiForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.worldMap_KeyDown);
            this.mapSplitContainer.Panel1.ResumeLayout(false);
            this.mapSplitContainer.Panel2.ResumeLayout(false);
            this.mapSplitContainer.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.componentPalletGroup.ResumeLayout(false);
            this.MwayLanes.ResumeLayout(false);
            this.MwayLanes.PerformLayout();
            this.MwayRamps.ResumeLayout(false);
            this.MwayRamps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleRoadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoLaneMwayIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeLaneMwayIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onRampIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offRampIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel worldMap;
        private System.Windows.Forms.SplitContainer mapSplitContainer;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel miniMapPanel;
        private System.Windows.Forms.GroupBox componentPalletGroup;
        private System.Windows.Forms.PictureBox offRampIcon;
        private System.Windows.Forms.PictureBox onRampIcon;
        private System.Windows.Forms.PictureBox singleRoadIcon;
        private System.Windows.Forms.PictureBox twoLaneMwayIcon;
        private System.Windows.Forms.PictureBox threeLaneMwayIcon;
        private System.Windows.Forms.GroupBox MwayLanes;
        private System.Windows.Forms.GroupBox MwayRamps;
        private System.Windows.Forms.Label onRampText;
        private System.Windows.Forms.Label offRampText;
        private System.Windows.Forms.Label singleRoadText;
        private System.Windows.Forms.Label twoLaneMwayText;
        private System.Windows.Forms.Label threeLaneMwayText;
    }
}