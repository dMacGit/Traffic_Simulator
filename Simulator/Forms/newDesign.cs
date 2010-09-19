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
    /// <summary> 
    /// NewDesign Form. This form is used to gather
    /// user defined parameters for the design form
    /// before it is created.
    /// </summary>
    
    public partial class newDesign : Form
    {
        /// <summary> 
        /// ParentDes Design. Design Controller.
        /// </summary>
        private Design parentDes;
        /// <summary> 
        /// Bounds Point. Point holding the user specified grid size.
        /// </summary>
        private Point bounds;
        /// <summary> 
        /// Small Point. Point holding preset small grid size.
        /// </summary>
        private Point small = new Point(32, 32);
        /// <summary> 
        /// Medium Point. Point holding preset medium grid size.
        /// </summary>
        private Point medium = new Point(64, 64);
        /// <summary> 
        /// Large Point. Point holding preset large grid size.
        /// </summary>
        private Point large = new Point(128, 128);
        /// <summary> 
        /// Name String. Specified design name.
        /// </summary>
        private String name;

        /// <summary> 
        /// NewDesign Constructor. Initializes the
        /// bounds parameter and also the designer
        /// components. Hides the custom grid options
        /// and specified the parent design controller.
        /// </summary>
        /// <param name="parentDes">Design</param>
        
        public newDesign(Design parentDes)
        {
            this.parentDes = parentDes;
            bounds = new Point(0,0);
            InitializeComponent();
            this.customSizeSet.Hide();
        }

        /// <summary> 
        /// WorldBounds Mutator Method. Gets or sets
        /// the bounds value.
        /// </summary>
        
        public Point worldBounds
        {
            get { return bounds; }
            set { bounds = value;}
        }

        /// <summary> 
        /// DesignName Mutator Method. Gets or sets
        /// the designName value.
        /// </summary>
        
        public String designName
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary> 
        /// ValidateDesignName Method. Checks the inputted
        /// string is a valid name.
        /// </summary>
        /// <param name="input">String</param>
        
        private bool validateDesignName(String input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");
        }

        /// <summary> 
        /// ValidateCustomGrid Method. Checks the inputted
        /// custom grid values are numbers and not letters.
        /// </summary>
        /// <param name="xString">String</param>
        /// <param name="yString">String</param>
        
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

        /// <summary> 
        /// ValidateGridBounds Method. Checks the passed point
        /// is valid. To be valid it must be divisible by 2,
        /// ie using % there is no remander, and also must be
        /// greater then the minimum bound of 32.
        /// </summary>
        /// <param name="toValidate">Point</param>
        
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

        /// <summary> 
        /// RadioButtonsGroup_CheckedChanged Event Handler method. Handles
        /// preset grid radio buttons pressed.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// CheckBoxButtonCustom_CheckedChanged Event Handler method. Handles
        /// the custom grid sizes check box being clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// IsFinished Event Handler method. Handles 
        /// when the user clicks the accept button.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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
