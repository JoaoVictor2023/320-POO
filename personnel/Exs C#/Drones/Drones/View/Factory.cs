using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone
    
    public partial class Factory : Building
    {
        int idFactory;
        bool essai;
        int timingCreate = 5000;
        float timerDelay = 0;
        public int IdFactory { get => idFactory; set => idFactory = value; }

        private Pen FactoryBrush = new Pen(new SolidBrush(Color.Purple), 2);


        // De manière graphique
        public void FactoryRender(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(FactoryBrush, new Rectangle(X - 4, Y - 2, 20, 20));
        }
        public void Update(int interval)
        {
            timerDelay += interval;
            if (timerDelay >= timingCreate + Helper.alea.Next(0,1500))
            {
                Console.WriteLine("Boîte créée");
                essai = false;
                timerDelay = 0;
            }
        }    
    }
    
}
