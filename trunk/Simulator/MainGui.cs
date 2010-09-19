using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Traffic_Simulator
{
    /// <summary> 
    /// MainGui Class. Is the class which is
    /// run to start the application. It creates
    /// mainGuiForm onto which the design and
    /// simulation are added and used.
    /// </summary>
    
	public class MainGui 
    {
        /// <summary>
        /// Application Startup/Run method.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainGuiForm mainDisplay = new MainGuiForm();
            Application.Run(mainDisplay);
        }
	}

}
