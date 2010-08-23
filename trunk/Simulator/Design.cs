using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    //Design Controller

    class Design
    {
        private RoadUnit[] roadUnits;
        private RoadSign[] roadSigns;
        private TrafficLight[] trafficLights;
        private int designID;
        private Design design;
        private MainGuiForm parent;
        private int mapWidthBounds;
        private Point worldBounds;
        private Point defaultWorld = new Point(128,64);

        /**
         * 
         * Design Constructer. Initalize the designGuiForm into the mainGuiForm
         * 
         */

        public Design(MainGuiForm parent)
        {
            System.Console.WriteLine("Called new DesignGui!");
            DesignGuiForm newDesignForm = new DesignGuiForm(defaultWorld);
            newDesignForm.MdiParent = parent;
            newDesignForm.WindowState = FormWindowState.Maximized;
            this.worldBounds = this.defaultWorld;
            //newDesignForm.mapBounds = worldBounds;
            //System.Console.WriteLine("Set world bounds: " + newDesignForm.mapBounds);
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
    }
}
