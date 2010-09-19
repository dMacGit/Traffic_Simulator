using System;
using System.Drawing;

namespace Traffic_Simulator
{
    /// <summary> 
    /// TrafficLight SuperClass. Super Class which holds all
    /// types of values that represent a generic traffic light.
    /// </summary>
    
	public class TrafficLight 
    {
        /// <summary> 
        /// LightID Integer. The Light id.
        /// </summary>
		private int lightID;
        /// <summary> 
        /// LightCoordinates Point. The Light coordinates.
        /// </summary>
		private Point lightCoordinates;
        /// <summary> 
        /// LightType String. The Light type.
        /// </summary>
		private String lightType;

        /// <summary> 
        /// LightType Mutator Method. Gets or Sets the lightType.
        /// </summary>
        
		public String LightType 
        {
            get { return lightType; }
            set { lightType = value; }
		}

        /// <summary> 
        /// LightCoordinates Mutator Method. Gets or Sets the lightCoordinates.
        /// </summary>
        
		public Point LightCoordinates
        {
            get { return lightCoordinates; }
            set { lightCoordinates = value; }
		}

        /// <summary> 
        /// LightID Mutator Method. Gets or Sets the lightID.
        /// </summary>
        
		public int LightID
        {
            get { return lightID; }
            set { lightID = value; }
		}

        /// <summary> 
        /// CheckLightCompatibility Method. Checks the surrounding
        /// tiles to see if this units placement is invalid.
        /// </summary>
        /// <param name="trafficLight">TrafficLight</param>
        
		public bool CheckLightCompatibility(TrafficLight trafficLight)
        {
            return true;
		}

        /// <summary> 
        /// Draw Method. Draws itself onto the graphics
        /// component passed, based on the offsets.
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="xOffSet">Integer</param>
        /// <param name="yOffSet">Integer</param>
        
        public void Draw(Graphics g, int xOffSet, int yOffSet)
        {
		}
	}

}
