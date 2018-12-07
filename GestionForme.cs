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

                case "bas":

                    //Vérification que l'action soit possible
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            //Si bloc coller au bord droite de la map
                            if (_map[x, y] > 0 && y == 23)
                            {
                                ok = false;
                            }
                        }
                    }

                    //Si l'action est possible
                    if (ok)
                    {
                        for (y = 23; y >= 0; y--)
                        {
                            for (x = 9; x >= 0; x--)
                            {
                                if (_map[x, y] > 0)
                                {
                                    //Effectue le déplacement d'un bloc
                                    _map[x, y + 1] = _map[x, y];
                                    _map[x, y] = 0;
                                }
                            }
                        }
                    }
                    break;

                case "haut":

                    //Vérification que l'action soit possible
                    for (y = 0; y < 24; y++)
                    {
                        for (x = 0; x < 10; x++)
                        {
                            //Si bloc coller au bord droite de la map
                            if (_map[x, y] > 0 && y == 0)
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
                                    _map[x, y - 1] = _map[x, y];
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
                            //Point de rotation = 11


                            //Check toutes la valeurs du tableau
                            for(y = 0; y < 24; y++)
                            {
                                for(x = 0; x < 10; x++)
                                {
                                    //Lorsqu'un bloc est trouvé
                                    if(_map[x, y] == 1)
                                    {
                                        _map[x, y] = 0;

                                        //Si bloc collé au bord droite (le baton est verticale dans ce cas)
                                        if (x == 9)
                                        {
                                            //Le point de rotation se trouve un bloc en dessous
                                            if (_map[x, y + 1] == 11)
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 2] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x, y + 1] = 1;
                                                _map[x - 1, y + 1] = 1;
                                                _map[x - 2, y + 1] = 11;
                                                _map[x - 3, y + 1] = 1;
                                            }
                                            //Le point de rotation se trouve deux blocs en dessous
                                            else
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x, y + 2] = 1;
                                                _map[x - 1, y + 2] = 11;
                                                _map[x - 2, y + 2] = 1;
                                                _map[x - 3, y + 2] = 1;
                                            }
                                        }
                                        //Si bloc à une case du bord droite (le baton est verticale dans ce cas)
                                        else if (x == 8)
                                        {
                                            //Le point de rotation se trouve un bloc en dessous
                                            if (_map[x, y + 1] == 11)
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 2] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x + 1, y + 1] = 1;
                                                _map[x, y + 1] = 1;
                                                _map[x - 1, y + 1] = 11;
                                                _map[x - 2, y + 1] = 1;
                                            }
                                            //Le point de rotation se trouve deux blocs en dessous
                                            else
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x + 1, y + 2] = 1;
                                                _map[x, y + 2] = 11;
                                                _map[x - 1, y + 2] = 1;
                                                _map[x - 2, y + 2] = 1;
                                            }
                                        }
                                        else
                                        {
                                            //Si bloc collé en bas (le baton est horizontale dans ce cas)
                                            if (y == 23)
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if(_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y] = 1;
                                                    _map[x + 1, y - 1] = 11;
                                                    _map[x + 1, y - 2] = 1;
                                                    _map[x + 1, y - 3] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                    _map[x + 2, y - 2] = 11;
                                                    _map[x + 2, y - 3] = 1;
                                                }
                                            }
                                            //Si bloc à une case du bas (le baton est horizontale dans ce cas)
                                            else if (y == 22)
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y] = 11;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y - 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y] = 1;
                                                    _map[x + 2, y - 1] = 11;
                                                    _map[x + 2, y - 2] = 1;
                                                }
                                            }
                                            //Si le bloc est collé au bord gauche
                                            else if (x == 0)
                                            {
                                                //Le point de rotation se trouve un bloc en dessous
                                                if (_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x, y + 1] = 1;
                                                    _map[x + 1, y + 1] = 11;
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 3, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if(_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x, y + 2] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                    _map[x + 2, y + 2] = 11;
                                                    _map[x + 3, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc plus loin
                                                else if(_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y - 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y + 2] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                            }
                                            //Si le bloc est collé au bord gauche
                                            else if (x == 1)
                                            {
                                                //Le point de rotation se trouve un bloc en dessous
                                                if (_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 1] = 1;
                                                    _map[x, y + 1] = 11;
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 2, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if (_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 2] = 1;
                                                    _map[x, y + 2] = 1;
                                                    _map[x + 1, y + 2] = 11;
                                                    _map[x + 2, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc plus loin
                                                else if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y - 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y + 2] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                            }
                                            //On ne sait pas si le baton est vertical ou horizontale
                                            else
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if(_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y - 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else if(_map[x + 2, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 2] = 1;
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc en dessous
                                                else if(_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 1] = 1;
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 2, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if(_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 2, y + 2] = 1;
                                                    _map[x - 1, y + 2] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                }
                                            }
                                        }
                                        //On sort de la boucle
                                        x = 10;
                                        y = 24;
                                    }
                                }
                            }
                            break;
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
                                    //Lorsqu'un bloc est trouvé
                                    if (_map[x, y] == 1)
                                    {
                                        _map[x, y] = 0;

                                        //Si bloc collé au bord droite (le baton est verticale dans ce cas)
                                        if (x == 9)
                                        {
                                            //Le point de rotation se trouve un bloc en dessous
                                            if (_map[x, y + 1] == 11)
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 2] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x, y + 1] = 1;
                                                _map[x - 1, y + 1] = 11;
                                                _map[x - 2, y + 1] = 1;
                                                _map[x - 3, y + 1] = 1;
                                            }
                                            //Le point de rotation se trouve deux blocs en dessous
                                            else
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x, y + 2] = 1;
                                                _map[x - 1, y + 2] = 1;
                                                _map[x - 2, y + 2] = 11;
                                                _map[x - 3, y + 2] = 1;
                                            }
                                        }
                                        //Si bloc à une case du bord droite (le baton est verticale dans ce cas)
                                        else if (x == 8)
                                        {
                                            //Le point de rotation se trouve un bloc en dessous
                                            if (_map[x, y + 1] == 11)
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 2] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x + 1, y + 1] = 1;
                                                _map[x, y + 1] = 11;
                                                _map[x - 1, y + 1] = 1;
                                                _map[x - 2, y + 1] = 1;
                                            }
                                            //Le point de rotation se trouve deux blocs en dessous
                                            else
                                            {
                                                //Suppression des anciennes positions
                                                _map[x, y + 1] = 0;
                                                _map[x, y + 3] = 0;

                                                //Initialisation des nouvelles positions
                                                _map[x + 1, y + 2] = 1;
                                                _map[x, y + 2] = 1;
                                                _map[x - 1, y + 2] = 11;
                                                _map[x - 2, y + 2] = 1;
                                            }
                                        }
                                        else
                                        {
                                            //Si bloc collé en bas (le baton est horizontale dans ce cas)
                                            if (y == 23)
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y - 2] = 11;
                                                    _map[x + 1, y - 3] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y] = 1;
                                                    _map[x + 2, y - 1] = 11;
                                                    _map[x + 2, y - 2] = 1;
                                                    _map[x + 2, y - 3] = 1;
                                                }
                                            }
                                            //Si bloc à une case du bas (le baton est horizontale dans ce cas)
                                            else if (y == 22)
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y] = 1;
                                                    _map[x + 1, y - 1] = 11;
                                                    _map[x + 1, y - 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y] = 11;
                                                    _map[x + 2, y - 1] = 1;
                                                    _map[x + 2, y - 2] = 1;
                                                }
                                            }
                                            //Si le bloc est collé au bord gauche
                                            else if (x == 0)
                                            {
                                                //Le point de rotation se trouve un bloc en dessous
                                                if (_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x, y + 1] = 1;
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 2, y + 1] = 11;
                                                    _map[x + 3, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if (_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x, y + 2] = 1;
                                                    _map[x + 1, y + 2] = 11;
                                                    _map[x + 2, y + 2] = 1;
                                                    _map[x + 3, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc plus loin
                                                else if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y - 2] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                            }
                                            //Si le bloc est collé au bord gauche
                                            else if (x == 1)
                                            {
                                                //Le point de rotation se trouve un bloc en dessous
                                                if (_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 1] = 1;
                                                    _map[x, y + 1] = 1;
                                                    _map[x + 1, y + 1] = 11;
                                                    _map[x + 2, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if (_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 2] = 1;
                                                    _map[x, y + 2] = 11;
                                                    _map[x + 1, y + 2] = 1;
                                                    _map[x + 2, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc plus loin
                                                else if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else
                                                {
                                                    //Suppression des anciennes position
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y - 2] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                            }
                                            //On ne sait pas si le baton est vertical ou horizontale
                                            else
                                            {
                                                //Le point de rotation se trouve un bloc plus loin
                                                if (_map[x + 1, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 2, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x + 1, y - 1] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs plus loin
                                                else if (_map[x + 2, y] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x + 1, y] = 0;
                                                    _map[x + 3, y] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y - 2] = 1;
                                                    _map[x + 2, y + 1] = 1;
                                                    _map[x + 2, y - 1] = 1;
                                                }
                                                //Le point de rotation se trouve un bloc en dessous
                                                else if (_map[x, y + 1] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 2] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x - 1, y + 1] = 1;
                                                    _map[x + 1, y + 1] = 1;
                                                    _map[x - 2, y + 1] = 1;
                                                }
                                                //Le point de rotation se trouve deux blocs en dessous
                                                else if (_map[x, y + 2] == 11)
                                                {
                                                    //Suppression des anciennes positions
                                                    _map[x, y + 1] = 0;
                                                    _map[x, y + 3] = 0;

                                                    //Initialisation des nouvelles positions
                                                    _map[x + 2, y + 2] = 1;
                                                    _map[x - 1, y + 2] = 1;
                                                    _map[x + 1, y + 2] = 1;
                                                }
                                            }
                                        }
                                        //On sort de la boucle
                                        x = 10;
                                        y = 24;
                                    }
                                }
                            }
                            break;
                    }
                    break;
            }
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
