using System;
namespace Traffic_Simulator
{
	public class Bus : Vehicle  
    {
        private const int MAX_SPEED = 80;
        private const int MIN_SPEED = 60;
        private String imageLocation = System.Environment.GetFolderPath
                                    (System.Environment.SpecialFolder.Personal)
                                    + @"\bus.png";
    
        public Bus()
        {
            SetVehiclePicture(imageLocation);
        }

        public void main()
        {
            Bus newBus = new Bus();

        }

	}

}
