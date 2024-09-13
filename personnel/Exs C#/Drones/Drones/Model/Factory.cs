namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Factory
    {


        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien

        public int X { get => _x; set => _x = value; }
        public int Y { get => y; set => y = value; }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += Helper.alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
        }

    }
}
