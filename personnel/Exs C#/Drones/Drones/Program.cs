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
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Création des buildings
            List<Building> fleetB = new List<Building>();
            for (int i = 0; i <= 5; i++)
            {
                Building building = new Building();
                building.X = Helper.alea.Next(0, Config.WIDTH);
                building.Y = Helper.alea.Next(0, Config.HEIGHT);
                building.BuildingColor = Color.Red;
                fleetB.Add(building);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, fleetB));
        }
    }
}