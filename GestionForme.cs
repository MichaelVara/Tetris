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

                case "cube":
                    _map[4, 4] = 2;
                    _map[5, 4] = 2;
                    _map[4, 5] = 2;
                    _map[5, 5] = 2;
                    break;

                case "l1":
                    _map[4, 5] = 3;
                    _map[5, 5] = 3;
                    _map[6, 5] = 3;
                    _map[6, 4] = 3;
                    break;

                case "l2":
                    _map[4, 4] = 4;
                    _map[4, 5] = 4;
                    _map[5, 5] = 4;
                    _map[6, 5] = 4;
                    break;

                case "s":
                    _map[4, 5] = 5;
                    _map[5, 5] = 5;
                    _map[5, 4] = 5;
                    _map[6, 4] = 5;
                    break;

                case "t":
                    _map[4, 5] = 6;
                    _map[5, 5] = 6;
                    _map[5, 4] = 6;
                    _map[6, 5] = 6;
                    break;

                case "z":
                    _map[4, 4] = 7;
                    _map[5, 4] = 7;
                    _map[5, 5] = 7;
                    _map[6, 5] = 7;
                    break;
            }
        }

        //Actions s'exécutant lorsque l'utilisateur appui sur une touche
        public void DeplacementForme(string action)
        {
            int x;
            int y;
            int block;
            bool ok = true;

            switch(action)
            {
                //Flèche gauche (déplacement vers la gauche)
                case "gauche":

                    //Vérification que l'action soit possible
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            //Si bloc coller au bord gauche de la map
                            if (_map[x, y] > 0 && x == 0)
                            {
                                ok = false;
                            }
                        }
                    }

                    //Si l'action est possible
                    if(ok)
                    {
                        for (y = 0; y < 24; y++)
                        {
                            for (x = 0; x < 10; x++)
                            {
                                if (_map[x, y] > 0)
                                {
                                    //Effectue le déplacement d'un bloc
                                    _map[x - 1, y] = _map[x, y];
                                    _map[x, y] = 0;
                                }
                            }
                        }
                    }
                    break;

                //Flèche droite (déplacement vers la droite)
                case "droite":

                    //Vérification que l'action soit possible
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            //Si bloc coller au bord droite de la map
                            if (_map[x, y] > 0 && x == 9)
                            {
                                ok = false;
                            }
                        }
                    }

                    //Si l'action est possible
                    if (ok)
                    {
                        for (y = 0; y < 24; y++)
                        {
                            for (x = 9; x >= 0; x--)
                            {
                                if (_map[x, y] > 0)
                                {
                                    //Effectue le déplacement d'un bloc
                                    _map[x + 1, y] = _map[x, y];
                                    _map[x, y] = 0;
                                }
                            }
                        }
                    }
                    break;
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
