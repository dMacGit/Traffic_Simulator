using System;
using System.Drawing;

namespace Traffic_Simulator {
	public class Vehicle {
		private int length;
		private String vehicleType;
		private int averageSpeed;
		private int maximumSpeed;
		private int drivingStyle;
		private int vehicleID;
		private bool isIndicating;
		private bool rightIndicating;
        private Point origin;
        private Point destination;
		private int indicationTime;
		private int laneNumber;

		public void SetVehicleID(int vehicleID) {
			throw new System.Exception("Not implemented");
		}
		public int GetVehicleID() {
			throw new System.Exception("Not implemented");
		}
        public void SetIndicating(bool isIndicating)
        {
			throw new System.Exception("Not implemented");
		}
		public void SetRightIndicating(bool rightIndicating) {
			throw new System.Exception("Not implemented");
		}
		public bool GetIsIndicating() {
			throw new System.Exception("Not implemented");
		}
		public bool GetRightIndicating() {
			throw new System.Exception("Not implemented");
		}
		public Point GetOrigin() {
			throw new System.Exception("Not implemented");
		}
		public Point GetDestination() {
			throw new System.Exception("Not implemented");
		}
		public void SetOrigin(Point origin) {
			throw new System.Exception("Not implemented");
		}
		public void SetDestination(Point destination) {
			throw new System.Exception("Not implemented");
		}
		public void SetIndicatingTime(int time) {
			throw new System.Exception("Not implemented");
		}
		public int GetIndicatingTime() {
			throw new System.Exception("Not implemented");
		}
		public void CalculateNewPosition(Point newPosition, int currentSpeed) {
			throw new System.Exception("Not implemented");
		}
		public void SetLaneNumber(int laneNumber) {
			throw new System.Exception("Not implemented");
		}
		public int GetLaneNumber() {
			throw new System.Exception("Not implemented");
		}
        public void Draw(System.Drawing.Graphics c, Graphics g)
        {
			throw new System.Exception("Not implemented");
		}
	}

}
