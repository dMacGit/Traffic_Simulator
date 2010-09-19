using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    /// <summary> 
    /// MainGuiForm. This is the main form for the application,
    /// and it handles all the gui events, such as button presses,
    /// mouse presses etc.
    /// </summary>
    
    public partial class MainGuiForm : Form
    {
        /// <summary> 
        /// DesignGuiForm DesignGuiForm. The form object for the design.
        /// </summary>
        private DesignGuiForm designGuiForm;

        /// <summary> 
        /// MainGuiForm Constructor. Initializes the designer components.
        /// </summary>
        
        public MainGuiForm()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        /// <summary> 
        /// MainGuiForm_Load Event Handler method. Handles user
        /// selecting to load/create a design/simulation.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
        private void MainGuiForm_Load(object sender, EventArgs e)
        {
            if (sender.ToString().CompareTo("Design") == 0)
            {
                if (designGuiForm == null)
                {
                    Console.WriteLine("Create a new Design!");
                    Design newTrafficDesign = new Design(this);
                }
            }

            if (sender.ToString().CompareTo("Simulation") == 0)
            {
                Console.WriteLine("Create a new Simulation!");
            }
        }
    }
}
