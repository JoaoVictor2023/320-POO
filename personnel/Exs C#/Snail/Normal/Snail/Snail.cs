using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSnail
{
    public class Snail
    {
        // Attributs

        public int vie = 50;                // Vie de l'escargot
        public int x = 0;                   // Position en x de l'escargot
        public int y;                       // Position en y de l'escargot
        public string enVie = "_@_ö";       // Escargot "vivant"
        public string mort = "____";        // Escargot "mort"

        // Constructeur

        public Snail(int startY)
        {
            y = startY;
        }

        public Snail()
        {
            y = 12;
        }

        // Méthodes

        public void Move()
        {
            x++;
            vie--;
        }
    }
}
