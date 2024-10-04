namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Building
    {


        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien

        public int X { get => _x; set => _x = value; }
        public int Y { get => y; set => y = value; }

       
    }
}
