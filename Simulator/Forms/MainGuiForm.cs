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
    public partial class MainGuiForm : Form
    {
        private DesignGuiForm designGuiForm;

        public MainGuiForm()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
