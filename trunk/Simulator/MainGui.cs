using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Traffic_Simulator
{
	public class MainGui 
    {
        private Graphics displayPanel;

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
