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
                    //designGuiForm = new DesignGuiForm();
                    //designGuiForm.Invalidate();
                    //designGuiForm.MdiParent = this;
                    //designGuiForm.WindowState = FormWindowState.Maximized;
                    //designGuiForm.Refresh();
                    //designGuiForm.Show();
                    //this.Refresh();
                    //this.Invalidate();
                    
                    
                    //Application.DoEvents();
                }
            }

            if (sender.ToString().CompareTo("Simulation") == 0)
            {
                Console.WriteLine("Create a new Simulation!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void designToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
