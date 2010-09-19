using System;
namespace Traffic_Simulator
{
    /// <summary> 
    /// LaneLight Class. Represents the arrow/lights overhead
    /// on the motorway, indicating lanes.
    /// </summary>
    
	public class LaneLight : TrafficLight  
    {
        /// <summary> 
        /// DispString String. Lane light value
        /// </summary>
        
		private String dispString;

        /// <summary> 
        /// DispString Mutator Method. Gets or Sets the dispString.
        /// </summary>
        
		public String DispString
        {
            get { return dispString; }
            set { dispString = value; }
		}

	}

}
