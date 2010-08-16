using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic_Simulator
{
    //Simulator Controller

    class Simulator
    {
        private Simulation simulation;
        private Design design;
        private int simulationID;
        private Vehicle[] vehicleType;
        private MeasurementTool[] measurementTool;
        private String simulationStatus;
        private int numOfVehicles;

        public String SimulationStatus
        {
            get
            {
                return simulationStatus;
            }
            set
            {
                simulationStatus = value;
            }
        }

        public int NumOfVehicles
        {
            get
            {
                return numOfVehicles;
            }
            set
            {
                numOfVehicles = value;
            }
        }

        public void saveSimulation(Simulation simulation, int simulationID)
        {
            //Saves the simulation with the simulation id to help destinguish between simulations
        }
        public Simulation loadSimulation(int simulationID)
        {
            //Loads the simulation with the simulation id to help destinguish between simulations
            return null;
        }

        public Design loadDesign()
        {
            //Loads the design to use in the simulation
            return null;
        }

        public void moveVehicle(Vehicle vehicle)
        {

        }

        /*
         * At the moment the simulator class would not work due to the omission of a simulation class
         * of any type. I have included a simulation inner class, only so the simulator can compile.
         * This structure of this simulator class is based on the uml class design. This obviuosly
         * needs some changes.
         */

        public class Simulation
        {

        }
    }
}
