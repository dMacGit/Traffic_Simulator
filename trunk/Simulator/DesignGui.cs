using System;
using System.Drawing;

namespace Traffic_Simulator 
{
	public class DesignGui : MainGui  
    {
        
        public DesignGui(MainGuiForm parentForm)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            System.Console.WriteLine("Called new DesignGui!");
            DesignGuiForm newDesignForm = new DesignGuiForm();
            newDesignForm.MdiParent = parentForm;
            newDesignForm.Show();
            
        }
		public void PaintComponent(Graphics g) 
        {
			throw new Exception("Not implemented");
		}
	}

}
