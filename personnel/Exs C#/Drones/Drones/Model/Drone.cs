namespace Drones
{
    public partial class Drone : IExpellable
    {
        private int _charge = 1000;
        private string _name;
        private int _x;
        private int _y;
        private EvacuationState _evacuationState = EvacuationState.Free;
        private Rectangle _noFlyZone;

        public Drone(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Charge { get => _charge; set => _charge = value; }
        public string Name { get => _name; set => _name = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public EvacuationState GetEvacuationState()
        {
            return _evacuationState;
        }

        public bool Evacuate(Rectangle zone)
        {
            _noFlyZone = zone;
            Rectangle droneBounds = new Rectangle(_x, _y, 1, 1); // Représente la position du drone

            if (droneBounds.IntersectsWith(zone))
            {
                _evacuationState = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                _evacuationState = EvacuationState.Evacuated;
                return true;
            }
        }

        public void FreeFlight()
        {
            _evacuationState = EvacuationState.Free;
            _noFlyZone = Rectangle.Empty;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 4; // Il s'est déplacé de 4 pixels vers la droite
            _y += Helper.alea.Next(-2, 3); // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--; // Il a dépensé de l'énergie

            // Si dans une zone d'exclusion, continue à évacuer
            Rectangle droneBounds = new Rectangle(_x, _y, 1, 1);
            if (_evacuationState == EvacuationState.Evacuating && droneBounds.IntersectsWith(_noFlyZone))
            {
                // Continue à bouger jusqu'à sortir de la zone
                if (!droneBounds.IntersectsWith(_noFlyZone))
                {
                    _evacuationState = EvacuationState.Evacuated;
                }
            }
        }
    }
}
