using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private Pen StoreBrush = new Pen(new SolidBrush(Color.Purple), 2);

        // De manière graphique
        public void StoreRender(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(StoreBrush, new Rectangle(X - 4, Y - 2, 15, 15));
        }
    }
}
