using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Traffic_Simulator
{
	public class MainGui 
    {
        private Form displayPanel;
        private DesignGuiForm designGuiForm;
        private DesignGui designGui;

        //private SimulationGuiForm simulationGuiForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainGuiForm());
        }
        public Graphics GetDisplay()
        {
			throw new Exception("Not implemented");
		}
        public void SetDisplay(Graphics panel)
        {
			throw new Exception("Not implemented");
		}

	}

}
