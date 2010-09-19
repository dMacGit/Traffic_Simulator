using System;
using System.Drawing;

namespace Traffic_Simulator 
{
    /// <summary> 
    /// RoadSign Class. Is used to signify a road sign.
    /// Contains all the raod sign properties.
    /// </summary>
    
	public class RoadSign
    {
        /// <summary> 
        /// SignID Integer. Value to store sign id.
        /// </summary>
		private int signID;
        /// <summary> 
        /// SignCoordinates Point. Value to store sign's position.
        /// </summary>
		private Point signCoordinates;
        /// <summary> 
        /// SignDescription String. Value to store sign's description.
        /// </summary>
		private String signDescription;

        /// <summary> 
        /// SignID Mutator Method. Gets or Sets the signID.
        /// </summary>
        
		public int SignID 
        {
            get { return signID; }
            set { signID = value; }
		}

        /// <summary> 
        /// SignCoordinates Mutator Method. Gets or Sets the signCoordinates.
        /// </summary>
        
		public Point SignCoordinates
        {
            get { return signCoordinates; }
            set { signCoordinates = value; }
		}

        /// <summary> 
        /// SignDescription Mutator Method. Gets or Sets the signDescription.
        /// </summary>
        
		public String SignDescription
        {
            get { return signDescription; }
            set { signDescription = value; }
		}

        /// <summary> 
        /// CheckSignCompatibility Method. Checks the surrounding
        /// tiles to see if this units placement is invalid.
        /// </summary>
        /// <param name="roadSign">RoadSign</param>
        
		public bool CheckSignCompatibility(RoadSign roadSign)
        {
            return true;
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
		}
	}

}
