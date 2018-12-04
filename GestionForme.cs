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
                    _map[3, 7] = 1;
                    _map[4, 7] = 11;
                    _map[5, 7] = 1;
                    _map[6, 7] = 1;
                    break;

                case "cube":
                    _map[4, 6] = 2;
                    _map[5, 6] = 2;
                    _map[4, 7] = 2;
                    _map[5, 7] = 2;
                    break;

                case "l1":
                    _map[4, 7] = 3;
                    _map[5, 7] = 13;
                    _map[6, 7] = 3;
                    _map[6, 6] = 3;
                    break;

                case "l2":
                    _map[4, 6] = 4;
                    _map[4, 7] = 4;
                    _map[5, 7] = 14;
                    _map[6, 7] = 4;
                    break;

                case "s":
                    _map[4, 7] = 5;
                    _map[5, 7] = 5;
                    _map[5, 6] = 15;
                    _map[6, 6] = 5;
                    break;

                case "t":
                    _map[4, 7] = 6;
                    _map[5, 7] = 16;
                    _map[5, 6] = 6;
                    _map[6, 7] = 6;
                    break;

                case "z":
                    _map[4, 6] = 7;
                    _map[5, 6] = 7;
                    _map[5, 7] = 17;
                    _map[6, 7] = 7;
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

                //Touche A (rotation gauche)
                case "a":
                    switch(_formeActuelle)
                    {
                        case "baton":
                            for(y = 0; y < 24; y++)
                            {
                                for(x = 0; x < 10; x++)
                                {
                                    //Effectue les vérifications et les déplacements pour la rotation avec des valeurs temporaires
                                    if(_map[x, y] == 1)
                                    {
                                        _map[x, y] = 0;

                                        if(x == 9)
                                        {
                                            if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y - 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x, y + 1] = 21;

                                                _map[x - 3, y + 1] = 21;
                                                _map[x - 2, y + 1] = 21;
                                                _map[x - 1, y + 1] = 11;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }

                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x, y - 2] = 21;

                                                _map[x - 1, y - 2] = 11;
                                                _map[x - 2, y - 2] = 21;
                                                _map[x - 3, y - 2] = 21;
                                            }

                                        }
                                        else if(x == 8)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y - 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }
                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }
                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }
                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x + 1, y - 2] = 21;

                                                _map[x, y - 2] = 11;
                                                _map[x - 1, y - 2] = 21;
                                                _map[x - 2, y - 2] = 21;
                                            }
                                        }
                                        else if(x == 0)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x, y + 1] = 21;

                                                _map[x + 1, y + 1] = 11;
                                                _map[x + 2, y + 1] = 21;
                                                _map[x + 3, y + 1] = 21;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x, y + 2] = 21;

                                                _map[x + 1, y + 2] = 21;
                                                _map[x + 2, y + 2] = 11;
                                                _map[x + 3, y + 2] = 21;

                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;
                                            }

                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }
                                        }
                                        else if(x == 1)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x - 1, y + 2] = 21;

                                                _map[x, y + 2] = 21;
                                                _map[x + 1, y + 2] = 11;
                                                _map[x + 2, y + 2] = 21;

                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;
                                            }

                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }
                                        }
                                        else
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y - 2] = 21;
                                            }
                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }

                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }
                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }
                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }
                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                    }

                    //Remet les valeurs de base des blocs
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            if (_map[x, y] == 21)
                            {
                                _map[x, y] = 1;
                            }
                        }
                    }
                    break;

                //Touche D (rotation droite)
                case "d":
                    switch (_formeActuelle)
                    {
                        case "baton":
                            for (y = 0; y < 24; y++)
                            {
                                for (x = 0; x < 10; x++)
                                {
                                    //Effectue les vérifications et les déplacements pour la rotation avec des valeurs temporaires
                                    if (_map[x, y] == 1)
                                    {
                                        _map[x, y] = 0;

                                        if(x == 9)
                                        {
                                            if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }

                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x, y + 1] = 21;
                                                
                                                _map[x - 1, y + 1] = 11;
                                                _map[x - 2, y + 1] = 21;
                                                _map[x - 3, y + 1] = 21;

                                                _map[x, y + 2] = 0;
                                                _map[x, y + 3] = 0;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x, y + 2] = 21;

                                                _map[x - 1, y + 2] = 21;
                                                _map[x - 2, y + 2] = 11;
                                                _map[x - 3, y + 2] = 21;

                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;
                                            }
                                        }
                                        else if(x == 8)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }

                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }

                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x + 1, y + 2] = 21;

                                                _map[x, y + 2] = 21;
                                                _map[x - 1, y + 2] = 11;
                                                _map[x - 2, y + 2] = 21;

                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;
                                            }

                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x - 2, y - 2] = 21;
                                            }
                                        }
                                        else if(x == 0)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }

                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11 && _map[x, y + 1] == 0)
                                            {
                                                _map[x, y - 1] = 21;

                                                _map[x + 1, y - 1] = 11;
                                                _map[x + 2, y - 1] = 21;
                                                _map[x + 3, y - 1] = 21;
                                            }

                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }

                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }

                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x, y - 2] = 21;

                                                _map[x + 1, y - 2] = 21;
                                                _map[x + 2, y - 2] = 11;
                                                _map[x + 3, y - 2] = 21;
                                            }
                                        }
                                        else if(x == 1)
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }

                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }

                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }


                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }
                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x - 1, y - 2] = 21;

                                                _map[x, y - 2] = 21;
                                                _map[x + 1, y - 2] = 11;
                                                _map[x + 2, y - 2] = 21;
                                            }
                                        }

                                        else
                                        {
                                            if (_map[x + 1, y] == 11)
                                            {
                                                _map[x + 1, y - 1] = 21;
                                            }
                                            else if (_map[x - 1, y] == 11)
                                            {
                                                _map[x - 1, y + 1] = 21;
                                            }
                                            else if (_map[x - 2, y] == 11)
                                            {
                                                _map[x - 2, y + 2] = 21;
                                            }
                                            else if (_map[x + 2, y] == 11)
                                            {
                                                _map[x + 2, y - 2] = 21;
                                            }

                                            else if (_map[x, y - 1] == 11)
                                            {
                                                _map[x - 1, y - 1] = 21;
                                            }
                                            else if (_map[x, y + 1] == 11)
                                            {
                                                _map[x + 1, y + 1] = 21;
                                            }
                                            else if (_map[x, y + 2] == 11)
                                            {
                                                _map[x + 2, y + 2] = 21;
                                            }
                                            else if (_map[x, y - 2] == 11)
                                            {
                                                _map[x - 2, y - 2] = 21;
                                            }
                                        }
                                    }
                                }
                            }


                            break;
                    }

                    //Remet les valeurs de base des blocs
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            if (_map[x, y] == 21)
                            {
                                _map[x, y] = 1;
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
