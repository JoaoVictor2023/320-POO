using Drones;
using Drones.Helpers;


namespace droneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NewDroneCharge1000()
        {
            Drone drone = new Drone();

            Assert.AreEqual(1000, drone.Charge, "La charge n'est pas égal a 100");
            

        }
        [TestMethod]
        public void batteryDown()
        {
            //    Drone drone = new Drone();
            //    drone.Result = drone.Charge;

            //    Assert.AreNotEqual(1000, drone.Result, "La charge ne descend pas a chaque update");
        }

    [TestMethod]
        public void LowBattery()
        {

            

        }

        [TestMethod]
        public void battery0()
        {



        }
    }
}