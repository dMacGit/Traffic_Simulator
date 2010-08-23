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
            this.mapSplitContainer.Panel1.SuspendLayout();
            this.mapSplitContainer.Panel2.SuspendLayout();
            this.mapSplitContainer.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
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
            this.componentPalletGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentPalletGroup.Location = new System.Drawing.Point(0, 0);
            this.componentPalletGroup.Name = "componentPalletGroup";
            this.componentPalletGroup.Padding = new System.Windows.Forms.Padding(5);
            this.componentPalletGroup.Size = new System.Drawing.Size(1374, 283);
            this.componentPalletGroup.TabIndex = 0;
            this.componentPalletGroup.TabStop = false;
            this.componentPalletGroup.Text = "Units";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel worldMap;
        private System.Windows.Forms.SplitContainer mapSplitContainer;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel miniMapPanel;
        private System.Windows.Forms.GroupBox componentPalletGroup;
    }
}