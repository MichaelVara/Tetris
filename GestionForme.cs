using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GestionForme
    {
        #region private attributes
        private string _formeActuelle;
        private int[,] _map = new int[10, 24];
        private bool _nouvellePiece = false;

        private FormeBaton _baton;
        private FormeCube _cube;
        private FormeL1 _l1;
        private FormeL2 _l2;
        private FormeS _s;
        private FormeT _t;
        private FormeZ _z;
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

            _baton = new FormeBaton();
            _cube = new FormeCube();
            _l1 = new FormeL1();
            _l2 = new FormeL2();
            _s = new FormeS();
            _t = new FormeT();
            _z = new FormeZ();
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

        public bool nouvellePiece()
        {
            return _nouvellePiece;
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
                    _map = _baton.Initialise(_map);
                    break;

                case "cube":
                    _cube.Initialise(_map);
                    break;

                case "l1":
                    _l1.Initialise(_map);
                    break;

                case "l2":
                    _l2.Initialise(_map);
                    break;

                case "s":
                    _s.Initialise(_map);
                    break;

                case "t":
                    _t.Initialise(_map);
                    break;

                case "z":
                    _z.Initialise(_map);
                    break;
            }
            //On n'a plus besoin d'une nouvelle pièce
            _nouvellePiece = false;
        }

        //Actions s'exécutant lorsque l'utilisateur appui sur une touche
        public void DeplacementForme(string action)
        {
            int x;
            int y;
            bool ok = true;
            bool pose = false;

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
                            if (_map[x, y] > 0 && _map[x, y] < 20)
                            {
                                if(x == 0)
                                {
                                    ok = false;
                                }
                                else if(_map[x - 1, y] > 20)
                                {
                                    ok = false;
                                }
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
                                if (_map[x, y] > 0 && _map[x, y] < 20)
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
                            if (_map[x, y] > 0 && _map[x, y] < 20)
                            {
                                if(x == 9)
                                {
                                    ok = false;
                                }
                                else if(_map[x + 1, y] > 20)
                                {
                                    ok = false;
                                }
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
                                if (_map[x, y] > 0 && _map[x, y] < 20)
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
                            if (_map[x, y] > 0 && _map[x, y] < 20)
                            {
                                if(y == 23)
                                {
                                    ok = false;
                                }
                                else if(_map[x, y + 1] > 20)
                                {
                                    ok = false;
                                }
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
                                if (_map[x, y] > 0 && _map[x, y] < 20)
                                {
                                    //Effectue le déplacement d'un bloc
                                    _map[x, y + 1] = _map[x, y];
                                    _map[x, y] = 0;

                                    if (y + 1 == 23)
                                    {
                                        pose = true;
                                    }
                                    else if (_map[x, y + 2] > 20)
                                    {
                                        pose = true;
                                    }
                                }
                            }
                        }
                        //Si la pièce est posée
                        if (pose)
                        {
                            //Pose définitivement la pièce dans la grille
                            PoserPiece();

                            //On a besoin d'une nouvelle pièce
                            _nouvellePiece = true;
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
                            if (_map[x, y] > 0 && _map[x, y] < 20 && y == 0)
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
                                if (_map[x, y] > 0 && _map[x, y] < 20)
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
                            _map = _baton.RotationGauche(_map);
                            break;

                        case "l1":
                            _map = _l1.RotationGauche(_map);
                            break;

                        case "l2":
                            _map = _l2.RotationGauche(_map);
                            break;

                        case "s":
                            _map = _s.RotationGauche(_map);
                            break;

                        case "t":
                            _map = _t.RotationGauche(_map);
                            break;

                        case "z":
                            _map = _z.RotationGauche(_map);
                            break;
                    }
                    break;

                //Touche D (rotation droite)
                case "d":
                    switch(_formeActuelle)
                    {
                        case "baton":
                            _map = _baton.RotationDroite(_map);
                            break;

                        case "l1":
                            _map = _l1.RotationDroite(_map);
                            break;

                        case "l2":
                            _map = _l2.RotationDroite(_map);
                            break;

                        case "s":
                            _map = _s.RotationDroite(_map);
                            break;

                        case "t":
                            _map = _t.RotationDroite(_map);
                            break;

                        case "z":
                            _map = _z.RotationDroite(_map);
                            break;
                    }
                    break;
            }
        }
        #endregion public methods

        #region private methods
        //Cette fonction permet de poser les pièces en bas
        private void PoserPiece()
        {
            int x;
            int y;

            for(y = 0; y < 24; y++)
            {
                for(x = 0; x < 10; x++)
                {
                    switch(_map[x, y])
                    {
                        case 1:
                        case 11:
                            _map[x, y] = 21;
                            break;

                        case 2:
                        case 12:
                            _map[x, y] = 22;
                            break;

                        case 3:
                        case 13:
                            _map[x, y] = 23;
                            break;

                        case 4:
                        case 14:
                            _map[x, y] = 24;
                            break;

                        case 5:
                        case 15:
                            _map[x, y] = 25;
                            break;

                        case 6:
                        case 16:
                            _map[x, y] = 26;
                            break;

                        case 7:
                        case 17:
                            _map[x, y] = 27;
                            break;
                    }
                }
            }
        }
        #endregion private methods
    }
}
