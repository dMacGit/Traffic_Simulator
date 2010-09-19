using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic_Simulator
{
    /// <summary> 
    /// Traffic Simulator, Simulator Controller. This Class is used as a controller
    /// to manage the simulation side of the application.
    /// </summary>

    class Simulator
    {
        /// <summary> 
        /// Simulation Simulator. The simulation.
        /// </summary>
        private Simulator simulation;
        /// <summary> 
        /// Design Design. The design loaded and used
        /// in the simulation.
        /// </summary>
        private Design design;
        /// <summary> 
        /// SimulationID Integer. The id value for the simulation.
        /// </summary>
        private int simulationID;
        /// <summary> 
        /// VehicleType Vehicle[]. Array holding all the vehicles.
        /// </summary>
        private Vehicle[] vehicleType;
        /// <summary> 
        /// MeasurementTool MeasurementTool[]. Array holding all the measurementTools.
        /// </summary>
        private MeasurementTool[] measurementTool;
        /// <summary> 
        /// SimulationStatus String. String stating what the simulation status is.
        /// </summary>
        private String simulationStatus;
        /// <summary> 
        /// NumOfVehicles Integer. The number of vehicles in the simulaion.
        /// </summary>
        private int numOfVehicles;

        /// <summary> 
        /// SimulationStatus Mutator method. Gets or sets
        /// the simulationStatus value.
        /// </summary>

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

        /// <summary> 
        /// NumOfVehicles Mutator method. Gets or sets
        /// the numOfVehicles value.
        /// </summary>
        
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

        /// <summary> 
        /// SaveSimulation method. Called when user wishes to save the
        /// simulation. It uses the Simulation object and the id to
        /// create the saved simulation file.
        /// </summary>
        /// <param name="simulation">Simulation</param>
        /// <param name="simulationID">Integer</param>
        
        public void saveSimulation(Simulator simulation, int simulationID)
        {
            //Saves the simulation with the simulation id to help destinguish between simulations
        }

        /// <summary> 
        /// LoadSimulation method. Called when user wishes to load
        /// an existing saved simulation.
        /// </summary>
        /// <param name="simulationID">Integer</param>
        
        public Simulator loadSimulation(int simulationID)
        {
            //Loads the simulation with the simulation id to help destinguish between simulations
            return null;
        }

        /// <summary> 
        /// LoadDesign method. Called when user wishes to create
        /// a new simulation. A design is needed before simulation
        /// can take place.
        /// </summary>
        
        public Design loadDesign()
        {
            //Loads the design to use in the simulation
            return null;
        }

        /// <summary> 
        /// MoveVehicle method. Used to move all the vehciles
        /// currently in the simulation.
        /// </summary>
        /// <param name="vehicle">Vehicle</param>
        
        public void moveVehicle(Vehicle vehicle)
        {

        }
    }
}