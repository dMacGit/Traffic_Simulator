using System;
namespace Traffic_Simulator
{
	public interface Vehicle_Properties {
		int GetLength();
		int GetAverageSpeed();
		int GetMaxSpeed();
		void SetLength(int length);
		void SetAverageSpeed(int averageSpeed);
		void SetMaximumSpeed(int maximumSpeed);
		int GetDrivingStyle();
		void SetDrivingStyle(int drivingStyle);

	}

}
