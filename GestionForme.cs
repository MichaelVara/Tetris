using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class GestionForme
    {
        #region private attributes
        private string _formeActuelle;
        private int[,] _map = new int[10, 24];
        #endregion private attributes

        #region constructors
        public GestionForme()
        {
            int x;
            int y;

            //Initialisation des variables
            _formeActuelle = null;
            for(y = 0; y < 24; y++)
            {
                for(x = 0; x < 10; x++)
                {
                    _map[x, y] = 0;
                }
            }
        }
        #endregion constructors

        #region accessors and mutators
        public int[,] map()
        {
            return _map;
        }

        public string formeActuelle()
        {
            return _formeActuelle;
        }
        #endregion accessors and mutators

        #region public methods
        public void NouvelleForme(string forme)
        {
            _formeActuelle = forme;

            //Création des formes dans le tableau
            switch (forme)
            {
                case "baton":
                    _map[3, 4] = 1;
                    _map[4, 4] = 1;
                    _map[5, 4] = 1;
                    _map[6, 4] = 1;
                    break;
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
