using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
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

        
        // Propriété pour la couleur de la box
        public SmartiesColor couleur { get; set; } = SmartiesColor.Orange;
        public int Id { get => id; set => id = value; }
        public int Poids { get => poids; set => poids = value; }



    }
}
