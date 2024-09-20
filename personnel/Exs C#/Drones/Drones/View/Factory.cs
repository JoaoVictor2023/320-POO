using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Factory : Building
    {
        private Pen FactoryBrush = new Pen(new SolidBrush(Color.Purple), 2);

        // De manière graphique
        public void FactoryRender(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(FactoryBrush, new Rectangle(X - 4, Y - 2, 20, 20));
        }
    }
}
