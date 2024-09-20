using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Building
    {
        // Propriété pour la couleur du bâtiment
        public Color BuildingColor { get; set; } = Color.Black;

        // Méthode pour rendre graphiquement le bâtiment
        public void BuildingRender(BufferedGraphics drawingSpace)
        {
            using (Pen buildingBrush = new Pen(new SolidBrush(BuildingColor), 3))
            {
                drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(X - 100, Y - 50, 10, 15));
            }
        }
    }
}
