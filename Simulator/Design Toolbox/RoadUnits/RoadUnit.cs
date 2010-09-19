using System;
using System.Drawing;

namespace Traffic_Simulator 
{
    /// <summary> 
    /// RoadUnit SuperClass. Super Class to which all sub classes:
    /// straight road, curve, offramp etc take there methods/values from.
    /// </summary>
    
	public class RoadUnit 
    {
        /// <summary> 
        /// UnitID Integer. The identification value of the unit.
        /// </summary>
		private int unitID;
        /// <summary> 
        /// Direction Direction. Direction of the unit.
        /// </summary>
		private Direction direction;
        /// <summary> 
        /// UnitCoordinates Point. The coordinates of the unit.
        /// </summary>
        private Point unitCoordinates;
        /// <summary> 
        /// GridNum Point. The grid number of the unit.
        /// </summary>
        private Point gridNum;
        /// <summary> 
        /// NumOfLanes Integer. The total number of lanes of the unit.
        /// </summary>
        private int numOfLanes;
        /// <summary> 
        /// Width Integer. The width of the unit.
        /// </summary>
        private int width;
        /// <summary> 
        /// Height Integer. The height of the unit.
        /// </summary>
        private int height;
        /// <summary> 
        /// Image Image. The unit's image/bitmap.
        /// </summary>
        private Image image;

        /// <summary> 
        /// UnitID Mutator Method. Gets or Sets the unitID value.
        /// </summary>
        
		public int UnitID 
        {
            get { return unitID; }
            set { unitID = value; }
		}

        /// <summary> 
        /// UnitPosition Mutator Method. Gets or Sets the unitCoordinates value.
        /// </summary>
        
        public Point unitPosition
        {
            get { return unitCoordinates; }
            set { unitCoordinates = value; }
        }

        /// <summary> 
        /// UnitImage Mutator Method. Gets or Sets the image value.
        /// </summary>
        
        public Image unitImage
        {
            set { image = value; }
            get { return image; }
        }

        /// <summary> 
        /// CheckDirectionCompatibility Method. Checks the surrounding
        /// tiles to see if this units orientation is invalid.
        /// </summary>
        /// <param name="roadUnit">RoadUnit</param>
        
		public bool CheckDirectionCompatibility(RoadUnit roadUnit)
        {
			throw new System.Exception("Not implemented");
		}

        /// <summary> 
        /// NumOfLanes Mutator Method. Gets or Sets the numOfLanes value.
        /// </summary>
        
		public int NumOfLanes 
        {
            get { return numOfLanes; }
            set { numOfLanes = value; }
		}

        /// <summary> 
        /// Width Mutator Method. Gets or Sets the width value.
        /// </summary>
        
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary> 
        /// Height Mutator Method. Gets or Sets the height value.
        /// </summary>
        
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary> 
        /// Draw Method. Draws itself onto the graphics
        /// component passed, based on the offsets.
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="xOffset">Integer</param>
        /// <param name="yOffset">Integer</param>
        
        public void Draw(Graphics g, int xOffset, int yOffset)
        {
            g.DrawImage(image, unitCoordinates.X + xOffset, unitCoordinates.Y + yOffset, width, height);
		}

        /// <summary> 
        /// GridValue Mutator Method. Gets or Sets the gridNum value.
        /// </summary>
        
        public Point gridValue
        {
            get { return gridNum; }
            set { gridNum = value; }
        }
	}

}
