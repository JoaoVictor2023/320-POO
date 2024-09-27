using Drones;
using Drones.Helpers;


namespace droneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

    //    [TestMethod]
    //    public void NewDroneCharge1000()
    //    {
    //        Drone drone = new Drone(0, 0);

    //        Assert.AreEqual(1000, drone.Charge, "La charge n'est pas égal a 100");


    //    }
    //    [TestMethod]
    //    public void batteryDown()
    //    {
    //        Drone drone = new Drone();
    //        drone.Result = drone.Charge;

    //        Assert.AreNotEqual(1000, drone.Result, "La charge ne descend pas a chaque update");
    //    }

    //    [TestMethod]
    //    public void LowBattery()
    //    {



    //    }

    //    [TestMethod]
    //    public void battery0()
    //    {



    //    }
    }
}