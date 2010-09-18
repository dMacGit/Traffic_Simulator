using System;
using System.Drawing;

namespace Traffic_Simulator 
{
	public class RoadUnit 
    {
		private int unitID;
		private Direction direction;
		private RoadUnit[] roadUnits;
		private Point unitCoordinates;
		private RoadUnit roadUnit;
		private int numOfLanes, width, height;
        private Image image;

		public int UnitID 
        {
            get { return unitID; }
            set { unitID = value; }
		}
        public Point unitPosition
        {
            get { return unitCoordinates; }
            set { unitCoordinates = value; }
        }
        public Image unitImage
        {
            set { image = value; }
            get { return image; }
        }
		public bool CheckDirectionCompatibility(RoadUnit roadUnit)
        {
			throw new System.Exception("Not implemented");
		}
		public int NumOfLanes 
        {
            get { return numOfLanes; }
            set { numOfLanes = value; }
		}
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public void Draw(System.Drawing.Graphics c, Graphics g)
        {
			throw new System.Exception("Not implemented");
		}
	}

}
