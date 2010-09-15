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
        private static MainGuiForm mainDisplay_Static;

        //private SimulationGuiForm simulationGuiForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainDisplay_Static = new MainGuiForm();
            Application.Run(mainDisplay_Static);
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
