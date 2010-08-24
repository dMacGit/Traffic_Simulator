using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    //Design Controller

    public class Design
    {
        private RoadUnit[] roadUnits;
        private RoadSign[] roadSigns;
        private TrafficLight[] trafficLights;
        private int designID;
        private String designName;
        private Design design;
        private MainGuiForm parent;
        private int mapWidthBounds;
        private Point worldBounds;
        private Point defaultWorld = new Point(128,64);
        private DesignGuiForm newDesignForm;
        private newDesign createNewDesign;

        /**
         * 
         * Design Constructer. Initalize the designGuiForm into the mainGuiForm
         * 
         */

        public Design(MainGuiForm parent)
        {
            this.parent = parent;
            System.Console.WriteLine("Called new DesignGui!");
            createNewDesign = new newDesign(this);
            createNewDesign.Show();
        }
        public void designParameterSet()
        {

            this.worldBounds = createNewDesign.worldBounds;
            this.designName = createNewDesign.designName;
            System.Console.WriteLine("Design name: " + designName);
            System.Console.WriteLine("Set world bounds: " + worldBounds);
            createNewDesign.Dispose();
            newDesignForm = new DesignGuiForm(worldBounds, designName);
            parent.Name = designName;
            newDesignForm.MdiParent = parent;
            newDesignForm.WindowState = FormWindowState.Maximized;
            newDesignForm.Show();
            newDesignForm.Refresh();
        }
        public void addRoadUnit(RoadUnit roadUnit)
        {

        }
        public void addRoadSign(RoadSign roadSign)
        {

        }
        public void addTrafficLight(TrafficLight trafficLight)
        {

        }
        public void removeTrafficLight(int lightID)
        {

        }
        public void removeRoadSign(int signID)
        {

        }
        public void removeRoadUnit(int roadID)
        {

        }
        public void saveDesign(Design dsign)
        {

        }
        public Design openDesign(int designID)
        {
            return null;
        }
        /*private void isFinished(object sender, EventArgs e)
        {
            createNewDesign.Dispose();
            designParameterSet();
        }*/
    }
}
