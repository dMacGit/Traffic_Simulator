using System;
using System.Drawing;

namespace Traffic_Simulator {
	public class RoadSign {
		private int signID;
		private Point signCoordinates;
		private String signDescription;
		private RoadSign roadSigns;
		private RoadSign roadSign;

		public int SetSignID() {
			throw new System.Exception("Not implemented");
		}
		public void SetSignCoordinates(Point signCoordinates) {
			throw new System.Exception("Not implemented");
		}
		public void SetDescription(String description) {
			throw new System.Exception("Not implemented");
		}
		public int GetSignID() {
			throw new System.Exception("Not implemented");
		}
		public Point GetSignCoordinates() {
			throw new System.Exception("Not implemented");
		}
		public String GetSignDescription() {
			throw new System.Exception("Not implemented");
		}
		public bool CheckSignCompatibility(RoadSign roadSign) {
			throw new System.Exception("Not implemented");
		}
        public void Draw(System.Drawing.Graphics c, Graphics g)
        {
			throw new System.Exception("Not implemented");
		}
	}

}
