namespace Drones
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {

        // La flotte est l'ensemble des drones qui �voluent dans notre espace a�rien
        private List<Drone> fleet;
        private List<Building> fleetB;
        private List<Factory> fleetF;
        private List<Store> fleetS;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace a�rien avec un certain nombre de drones
        // Initialisation de l'espace a�rien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> fleetB, List<Factory> fleetF, List<Store> fleetS)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);

            // V�rifie si la liste de drones contient plus de 10 drones
            if (fleet.Count > 10)
            {
                throw new Exception("La flotte ne peut pas contenir plus de 10 drones.");
            }

            this.fleet = fleet;
            this.fleetB = fleetB;
            this.fleetF = fleetF;
            this.fleetS = fleetS;

        }

        // Affichage de la situation actuelle
        private void Render()
        {

            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }
            // draw building
            foreach (Building building in fleetB)
            {
                building.BuildingRender(airspace);
            }
            // draw factory
            foreach (Factory factory in fleetF)
            {
                factory.FactoryRender(airspace);
            }
            // draw store
            foreach (Store store in fleetS)
            {
                store.StoreRender(airspace);
            }

            airspace.Render();
        }

        // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
        private void Update(int interval)
        {
            foreach (Drone drone in fleet)
            {
                drone.Update(interval);
            }
            foreach (Factory factory in fleetF)
            {
                factory.Update(interval);
            }
        }

        // M�thode appel�e � chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}