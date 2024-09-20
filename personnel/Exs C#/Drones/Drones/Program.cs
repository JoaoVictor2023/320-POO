using System.Windows.Forms;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = Helper.alea.Next(0, Config.WIDTH);
            drone.Y = Helper.alea.Next(0, Config.HEIGHT);
            drone.Name = "Bob";
            fleet.Add(drone);

            

            // Création des buildings
            List<Building> fleetB = new List<Building>();
            for (int i = 0; i <= 5; i++)
            {
                Building building = new Building();
                building.X = Helper.alea.Next(0, Config.WIDTH - 100);
                building.Y = Helper.alea.Next(0, Config.HEIGHT - 50);
                building.BuildingColor = Color.Red;
                fleetB.Add(building);
            }

            // Création des Factory
            List<Factory> fleetF = new List<Factory>();
            for (int i = 0; i <= 5; i++)
            {
                Factory factory = new Factory();
                factory.X = Helper.alea.Next(100, Config.WIDTH - 100);
                factory.Y = Helper.alea.Next(50, Config.HEIGHT - 50);
                fleetF.Add(factory);
            }

            // Création des Stores
            List<Store> fleetS = new List<Store>();
            for (int i = 0; i <= 5; i++)
            {
                Store store = new Store();
                store.X = Helper.alea.Next(100, Config.WIDTH - 100);
                store.Y = Helper.alea.Next(50, Config.HEIGHT - 50);
                fleetS.Add(store);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, fleetB, fleetF, fleetS));
        }
    }
}