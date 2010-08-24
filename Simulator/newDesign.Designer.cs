namespace Traffic_Simulator
{
    partial class newDesign
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
            this.okButton = new System.Windows.Forms.Button();
            this.enterNameBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.Label();
            this.customSizeSet = new System.Windows.Forms.GroupBox();
            this.yGridSize = new System.Windows.Forms.Label();
            this.xGridSize = new System.Windows.Forms.Label();
            this.customYvalue = new System.Windows.Forms.TextBox();
            this.customXvalue = new System.Windows.Forms.TextBox();
            this.smallGridOption = new System.Windows.Forms.RadioButton();
            this.mediumGridOption = new System.Windows.Forms.RadioButton();
            this.largeGridOption = new System.Windows.Forms.RadioButton();
            this.presetOptions = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customGridOption = new System.Windows.Forms.CheckBox();
            this.customSizeSet.SuspendLayout();
            this.presetOptions.SuspendLayout();
            this.nameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(233, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 24);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Accept";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.isFinished);
            // 
            // enterNameBox
            // 
            this.enterNameBox.Location = new System.Drawing.Point(61, 16);
            this.enterNameBox.Name = "enterNameBox";
            this.enterNameBox.Size = new System.Drawing.Size(127, 20);
            this.enterNameBox.TabIndex = 1;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(17, 19);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(38, 13);
            this.nameText.TabIndex = 2;
            this.nameText.Text = "Name:";
            // 
            // customSizeSet
            // 
            this.customSizeSet.Controls.Add(this.yGridSize);
            this.customSizeSet.Controls.Add(this.xGridSize);
            this.customSizeSet.Controls.Add(this.customYvalue);
            this.customSizeSet.Controls.Add(this.customXvalue);
            this.customSizeSet.Location = new System.Drawing.Point(146, 77);
            this.customSizeSet.Name = "customSizeSet";
            this.customSizeSet.Size = new System.Drawing.Size(167, 105);
            this.customSizeSet.TabIndex = 3;
            this.customSizeSet.TabStop = false;
            this.customSizeSet.Text = "Custom Grid";
            // 
            // yGridSize
            // 
            this.yGridSize.AutoSize = true;
            this.yGridSize.Location = new System.Drawing.Point(18, 67);
            this.yGridSize.Name = "yGridSize";
            this.yGridSize.Size = new System.Drawing.Size(17, 13);
            this.yGridSize.TabIndex = 3;
            this.yGridSize.Text = "Y:";
            // 
            // xGridSize
            // 
            this.xGridSize.AutoSize = true;
            this.xGridSize.Location = new System.Drawing.Point(18, 26);
            this.xGridSize.Name = "xGridSize";
            this.xGridSize.Size = new System.Drawing.Size(17, 13);
            this.xGridSize.TabIndex = 2;
            this.xGridSize.Text = "X:";
            // 
            // customYvalue
            // 
            this.customYvalue.Location = new System.Drawing.Point(41, 62);
            this.customYvalue.Name = "customYvalue";
            this.customYvalue.Size = new System.Drawing.Size(93, 20);
            this.customYvalue.TabIndex = 1;
            // 
            // customXvalue
            // 
            this.customXvalue.Location = new System.Drawing.Point(41, 21);
            this.customXvalue.Name = "customXvalue";
            this.customXvalue.Size = new System.Drawing.Size(94, 20);
            this.customXvalue.TabIndex = 0;
            // 
            // smallGridOption
            // 
            this.smallGridOption.AutoSize = true;
            this.smallGridOption.Location = new System.Drawing.Point(20, 22);
            this.smallGridOption.Name = "smallGridOption";
            this.smallGridOption.Size = new System.Drawing.Size(60, 17);
            this.smallGridOption.TabIndex = 4;
            this.smallGridOption.TabStop = true;
            this.smallGridOption.Text = "32 x 32";
            this.smallGridOption.UseVisualStyleBackColor = true;
            this.smallGridOption.CheckedChanged += new System.EventHandler(this.radioButtonsGroup_CheckedChanged);
            // 
            // mediumGridOption
            // 
            this.mediumGridOption.AutoSize = true;
            this.mediumGridOption.Location = new System.Drawing.Point(20, 65);
            this.mediumGridOption.Name = "mediumGridOption";
            this.mediumGridOption.Size = new System.Drawing.Size(60, 17);
            this.mediumGridOption.TabIndex = 5;
            this.mediumGridOption.TabStop = true;
            this.mediumGridOption.Text = "64 x 64";
            this.mediumGridOption.UseVisualStyleBackColor = true;
            this.mediumGridOption.CheckedChanged += new System.EventHandler(this.radioButtonsGroup_CheckedChanged);
            // 
            // largeGridOption
            // 
            this.largeGridOption.AutoSize = true;
            this.largeGridOption.Location = new System.Drawing.Point(20, 105);
            this.largeGridOption.Name = "largeGridOption";
            this.largeGridOption.Size = new System.Drawing.Size(72, 17);
            this.largeGridOption.TabIndex = 6;
            this.largeGridOption.TabStop = true;
            this.largeGridOption.Text = "128 x 128";
            this.largeGridOption.UseVisualStyleBackColor = true;
            this.largeGridOption.CheckedChanged += new System.EventHandler(this.radioButtonsGroup_CheckedChanged);
            // 
            // presetOptions
            // 
            this.presetOptions.Controls.Add(this.mediumGridOption);
            this.presetOptions.Controls.Add(this.largeGridOption);
            this.presetOptions.Controls.Add(this.smallGridOption);
            this.presetOptions.Location = new System.Drawing.Point(18, 77);
            this.presetOptions.Name = "presetOptions";
            this.presetOptions.Size = new System.Drawing.Size(103, 138);
            this.presetOptions.TabIndex = 7;
            this.presetOptions.TabStop = false;
            this.presetOptions.Text = "Preset";
            // 
            // nameBox
            // 
            this.nameBox.Controls.Add(this.customGridOption);
            this.nameBox.Controls.Add(this.nameText);
            this.nameBox.Controls.Add(this.enterNameBox);
            this.nameBox.Location = new System.Drawing.Point(18, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(295, 50);
            this.nameBox.TabIndex = 8;
            this.nameBox.TabStop = false;
            this.nameBox.Text = "Design Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // customGridOption
            // 
            this.customGridOption.AutoSize = true;
            this.customGridOption.Location = new System.Drawing.Point(205, 19);
            this.customGridOption.Name = "customGridOption";
            this.customGridOption.Size = new System.Drawing.Size(84, 17);
            this.customGridOption.TabIndex = 10;
            this.customGridOption.Text = "Custom Size";
            this.customGridOption.UseVisualStyleBackColor = true;
            this.customGridOption.CheckedChanged += new System.EventHandler(this.checkBoxButtonCustom_CheckedChanged);
            // 
            // newDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(332, 232);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.presetOptions);
            this.Controls.Add(this.customSizeSet);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Design";
            this.customSizeSet.ResumeLayout(false);
            this.customSizeSet.PerformLayout();
            this.presetOptions.ResumeLayout(false);
            this.presetOptions.PerformLayout();
            this.nameBox.ResumeLayout(false);
            this.nameBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox enterNameBox;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.GroupBox customSizeSet;
        private System.Windows.Forms.TextBox customYvalue;
        private System.Windows.Forms.TextBox customXvalue;
        private System.Windows.Forms.RadioButton smallGridOption;
        private System.Windows.Forms.RadioButton mediumGridOption;
        private System.Windows.Forms.RadioButton largeGridOption;
        private System.Windows.Forms.GroupBox presetOptions;
        private System.Windows.Forms.GroupBox nameBox;
        private System.Windows.Forms.Label yGridSize;
        private System.Windows.Forms.Label xGridSize;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox customGridOption;
    }
}