namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Factory : Building
    {
        private int _charge = 1000;

        public int Charge { get => _charge; set => _charge = value; }

        public void Update(int interval)
        {
            Charge--;                                  // Il a dépensé de l'énergie
        }
    }
}
