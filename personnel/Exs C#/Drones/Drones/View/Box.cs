using Drones;
public enum SmartiesColor
{
    rouge,
    jaune,
    bleu,
    Brun,
    Orange
}
public partial class Box
{
    int id;
    int poids = Helper.alea.Next(5000, 10000);

    // Propriété pour la couleur de la box, choisie aléatoirement
    public SmartiesColor couleur { get; set; }

    public int Id { get => id; set => id = value; }
    public int Poids { get => poids; set => poids = value; }

    public Box()
    {
        // Générer une couleur aléatoire
        Array colors = Enum.GetValues(typeof(SmartiesColor));
        couleur = (SmartiesColor)colors.GetValue(Helper.alea.Next(colors.Length));
    }
}
