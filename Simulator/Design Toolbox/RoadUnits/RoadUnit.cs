using System;
using System.Drawing;

namespace Traffic_Simulator 
{
	public class RoadUnit 
    {
		private int unitID;
		private Direction direction;
		private RoadUnit[] roadUnits;
        private Point unitCoordinates, gridNum;
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
        public void Draw(Graphics g, int xOffset, int yOffset)
        {
            g.DrawImage(image, unitCoordinates.X + xOffset, unitCoordinates.Y + yOffset, width, height);
		}
        public Point gridValue
        {
            get { return gridNum; }
            set { gridNum = value; }
        }
	}

}
