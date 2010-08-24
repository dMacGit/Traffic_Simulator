using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Traffic_Simulator
{
    public partial class newDesign : Form
    {
        private bool hasFinished = false;
        private Design parentDes;
        private Point bounds, small = new Point(32,32), medium = new Point(64,64), large = new Point(128,128);
        private String name;
        private bool customCheckPrevState = false;

        public newDesign()
        {
            bounds = new Point(0, 0);
            InitializeComponent();
        }

        public newDesign(Design parentDes)
        {
            this.parentDes = parentDes;
            bounds = new Point(0,0);
            InitializeComponent();
            this.customSizeSet.Hide();
        }
        public Point worldBounds
        {
            get { return bounds; }
            set { bounds = value;}
        }
        public String designName
        {
            get { return name; }
            set { name = value; }
        }
        private bool validateDesignName(String input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");
        }
        private bool validateCustomGrid(String xString, String yString)
        {
            int n;
            if (int.TryParse(xString, out n) && int.TryParse(yString, out n))
            {
                return true;
            }
            else
                return false;
        }
        private bool validateGridBounds(Point toValidate)
        {
            if (toValidate.X % 2 > 0 || toValidate.Y % 2 > 0)
            {
                return false;
            }
            if (toValidate.X < 32 || toValidate.Y < 32)
            {
                return false;
            }
            return true;

        }
        private void radioButtonsGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.smallGridOption.Checked)
            {
                bounds = small;
            }
            else if (this.mediumGridOption.Checked)
            {
                bounds = medium;
            }
            else if (this.largeGridOption.Checked)
            {
                bounds = large;
            }
        }
        private void checkBoxButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.customGridOption.Checked)
            {
                this.presetOptions.Hide();
                this.customSizeSet.Show();
            }
            else if (!this.customGridOption.Checked)
            {
                this.presetOptions.Show();
                this.customSizeSet.Hide();
            }
        }
        private void isFinished(object sender, EventArgs e)
        {

            if (!validateDesignName(this.enterNameBox.Text))
            {
                if (MessageBox.Show("Invalid Parameter(s)!" + name + "?!?", "Please retry", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else if (this.customGridOption.Checked)
            {
                Point temp = new Point(0,0);

                if (validateCustomGrid(this.customXvalue.Text,this.customYvalue.Text))
                {
                    temp = new Point(int.Parse(this.customXvalue.Text),int.Parse(this.customYvalue.Text));
                }
                if (!validateGridBounds(temp))
                {
                    if (MessageBox.Show("Invalid Parameter(s)!" + temp.X + "," + temp.Y + "?!?", "Please retry", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                    }
                }
                else
                {
                    bounds = temp;
                    name = this.enterNameBox.Text;
                    parentDes.designParameterSet();
                }
            }
            else if (!validateGridBounds(bounds))
            {
                if (MessageBox.Show("Invalid Parameter(s)! : " + bounds.X + "," + bounds.Y + "?!?", "Please retry", MessageBoxButtons.OK) == DialogResult.OK)
                {
                }
            }
            else
            {
                name = this.enterNameBox.Text;
                parentDes.designParameterSet();
            }
        }
    }
}
