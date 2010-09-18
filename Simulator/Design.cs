using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Point defaultWorld = new Point(128, 64);
        private DesignGuiForm newDesignForm;
        private newDesign createNewDesign;
        private RoadUnit[,] designUnitArray;
        private int roadUnitStartingId = 0;

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
            //The box to set design parameters.
            this.worldBounds = createNewDesign.worldBounds;
            this.designName = createNewDesign.designName;
            System.Console.WriteLine("Design name: " + designName);
            System.Console.WriteLine("Set world bounds: " + worldBounds);
            createNewDesign.Dispose();
            newDesignForm = new DesignGuiForm(worldBounds, designName, this);
            System.Console.WriteLine("Main Display name changed from: " + parent.Text);
            parent.Text = designName;
            System.Console.WriteLine(" to: " + parent.Text);
            parent.Refresh();
            parent.Show();
            newDesignForm.MdiParent = parent;
            newDesignForm.WindowState = FormWindowState.Maximized;
            newDesignForm.Show();
            newDesignForm.Refresh();

            //Setup arrays of units
            designUnitArray = new RoadUnit[worldBounds.Y, worldBounds.X];
        }
        public bool addRoadUnit(RoadUnit roadUnit)
        {
            if (designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X] == null)
            {
                if (roadUnit.NumOfLanes > 1)
                {
                    int count = roadUnit.NumOfLanes-1;
                    while (count > 0)
                    {
                        if (designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X + count] != null)
                        {
                            System.Console.WriteLine("Road unit: id-" + designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X + count].UnitID + " allready occupies [" + roadUnit.gridValue.Y + "," + (roadUnit.gridValue.X+count) + "]");
                            return false;
                        }
                        else
                            count--;
                    }
                    roadUnit.UnitID = roadUnitStartingId;
                    roadUnitStartingId++;
                    while (count < (roadUnit.NumOfLanes-1) )
                    {
                        designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X+count] = roadUnit;
                        if (count == 0)
                        {
                            System.Console.Write("Added unit [ id-" + roadUnit.UnitID + "] to posistions: {" + roadUnit.gridValue.Y + "," + (roadUnit.gridValue.X + count)+"},");
                        }
                        else
                            System.Console.Write("{" + roadUnit.gridValue.Y + "," + (roadUnit.gridValue.X + count) + "},");
                        count++;
                    }
                    System.Console.WriteLine("");
                    return true;
                }
                else
                {
                    roadUnit.UnitID = roadUnitStartingId;
                    roadUnitStartingId++;
                    designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X] = roadUnit;
                    System.Console.WriteLine("Added unit [ id-"+roadUnit.UnitID+" ] to posistion: " + roadUnit.gridValue.Y + "," + roadUnit.gridValue.X);
                    return true;
                }
            }
            else
            {
                System.Console.WriteLine("Error adding unit: [ Row:" + roadUnit.gridValue.Y + ", Coloumn:" + roadUnit.gridValue.X + "] Taken by: id-" + designUnitArray[roadUnit.gridValue.Y, roadUnit.gridValue.X].UnitID);
                return false;
            }
            return false;
        }
        public RoadUnit[,] modifiedUnitArray
        {
            get { return designUnitArray; }
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
