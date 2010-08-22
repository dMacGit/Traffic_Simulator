using System;
using System.Drawing;

namespace Traffic_Simulator {
	public class RoadUnit {
		private int unitID;
		private Direction direction;
		private RoadUnit roadUnits;
		private Point unitCoordinates;
		private RoadUnit roadUnit;
		private int numOfLanes;

		public void SetUnitID(int unitID) {
			throw new System.Exception("Not implemented");
		}
		public int GetUnitID() {
			throw new System.Exception("Not implemented");
		}
		public bool CheckDirectionCompatibility(RoadUnit roadUnit) {
			throw new System.Exception("Not implemented");
		}
		public void SetNumOfLanes(int numOfLanes) {
			throw new System.Exception("Not implemented");
		}
		public int GetNumOfLanes() {
			throw new System.Exception("Not implemented");
		}
        public void Draw(System.Drawing.Graphics c, Graphics g)
        {
			throw new System.Exception("Not implemented");
		}
	}

}
