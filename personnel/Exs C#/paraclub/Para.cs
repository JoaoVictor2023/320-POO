using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Para
    {
        // View attributes
        private const int PARA_HEIGHT = 6;

        private string[] _viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] _viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        // Model attributes

        private string _name;
        private int _x;
        private int _altitude;
        private bool _parachuteIsOpen;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Para(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Make the parachutist move
        /// </summary>
        internal void update()
        {
            if (_altitude > PARA_HEIGHT) // il est en l'air
            {
                if (_parachuteIsOpen)
                {
                    _altitude -= 1; // il tombe lentement
                }
                else
                {
                    _altitude -= 3; // il tombe vite
                }
                // Décision d'ouvrir le parachute
                if (_altitude < Config.SCREEN_HEIGHT / 2)
                {
                    _parachuteIsOpen = true;
                }
            }
            else // il est au sol
            {
                _parachuteIsOpen = false;
            }
        }

        public void draw()
        {
            string[] view = _parachuteIsOpen ? _viewWithParachute : _viewNoParachute;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, Config.SCREEN_HEIGHT - this._altitude + i);
                Console.Write(view[i]);
            }
            Console.SetCursorPosition(_x, Config.SCREEN_HEIGHT - this._altitude - 1);
            Console.Write(this._name);
        }

    }
}
