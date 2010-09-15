using System;
using System.Drawing;

namespace Traffic_Simulator {
	public class Vehicle {
		private int length;
		private String vehicleType;
		private int speed;
		private int drivingStyle;
		private int vehicleID;
		private bool isIndicating;
		private bool rightIndicating;
        private Point origin;
        private Point destination;
		private int indicationTime;
		private int laneNumber;
        private Image vehiclePicture;

        public int GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public void SetVehiclePicture(String filename)
        {
            this.vehiclePicture = Image.FromFile(filename);
        }
		public void SetVehicleID(int vehicleID) {
            this.vehicleID = vehicleID;
		}
		public int GetVehicleID() {
            return vehicleID;
		}
        public void SetIndicating(bool isIndicating){
            this.isIndicating = isIndicating;
		}
		public void SetRightIndicating(bool rightIndicating) {
            this.rightIndicating = rightIndicating;			
		}
		public bool GetIsIndicating() {
            return isIndicating;
		}
		public bool GetRightIndicating() {
            return rightIndicating;
		}
		public Point GetOrigin() {
            return origin;
		}
		public Point GetDestination() {
            return destination;
		}
		public void SetOrigin(Point origin) {
            this.origin = origin;
		}
		public void SetDestination(Point destination) {
            this.destination = destination;
		}
		public void SetIndicatingTime(int time) {
            this.indicationTime = time;
		}
		public int GetIndicatingTime() {
            return indicationTime;
		}
		public void CalculateNewPosition(Point newPosition, int currentSpeed) {
			throw new System.Exception("Not implemented");
		}
		public void SetLaneNumber(int laneNumber) {
            this.laneNumber = laneNumber;
		}
		public int GetLaneNumber() {
            return laneNumber;
		}
        public void Draw(System.Drawing.Graphics c, Graphics g)
        {
			throw new System.Exception("Not implemented");
		}
	}

}
