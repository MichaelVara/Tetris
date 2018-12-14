using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class FormeBaton
    {
        #region privates attributes
        #endregion privates attributes

        #region constructor
        #endregion constructor

        #region accessors and mutators
        //Initialise les positions de base
        public int[,] Initialise(int[,] map)
        {
            map[3, 3] = 1;
            map[4, 3] = 11;
            map[5, 3] = 1;
            map[6, 3] = 1;

            return map;
        }

        //Effectue une rotation vers la gauche
        public int[,] RotationGauche(int[,] map)
        {
            int x;
            int y;

            //Point de rotation = 11


            //Check toutes les valeurs du tableau
            for (y = 0; y < 24; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    //Lorsqu'un bloc est trouvé
                    if (map[x, y] == 1)
                    {
                        map[x, y] = 0;

                        //Si bloc collé au bord droite (le baton est verticale dans ce cas)
                        if (x == 9)
                        {
                            //Le point de rotation se trouve un bloc en dessous
                            if (map[x, y + 1] == 11)
                            {
                                //Suppression des anciennes positions
                                map[x, y + 2] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x, y + 1] = 1;
                                map[x - 1, y + 1] = 1;
                                map[x - 2, y + 1] = 11;
                                map[x - 3, y + 1] = 1;
                            }
                            //Le point de rotation se trouve deux blocs en dessous
                            else
                            {
                                //Suppression des anciennes positions
                                map[x, y + 1] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x, y + 2] = 1;
                                map[x - 1, y + 2] = 11;
                                map[x - 2, y + 2] = 1;
                                map[x - 3, y + 2] = 1;
                            }
                        }
                        //Si bloc à une case du bord droite (le baton est verticale dans ce cas)
                        else if (x == 8)
                        {
                            //Le point de rotation se trouve un bloc en dessous
                            if (map[x, y + 1] == 11)
                            {
                                //Suppression des anciennes positions
                                map[x, y + 2] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x + 1, y + 1] = 1;
                                map[x, y + 1] = 1;
                                map[x - 1, y + 1] = 11;
                                map[x - 2, y + 1] = 1;
                            }
                            //Le point de rotation se trouve deux blocs en dessous
                            else
                            {
                                //Suppression des anciennes positions
                                map[x, y + 1] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x + 1, y + 2] = 1;
                                map[x, y + 2] = 11;
                                map[x - 1, y + 2] = 1;
                                map[x - 2, y + 2] = 1;
                            }
                        }
                        else
                        {
                            //Si bloc collé en bas (le baton est horizontale dans ce cas)
                            if (y == 23)
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y] = 1;
                                    map[x + 1, y - 1] = 11;
                                    map[x + 1, y - 2] = 1;
                                    map[x + 1, y - 3] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y] = 1;
                                    map[x + 2, y - 1] = 1;
                                    map[x + 2, y - 2] = 11;
                                    map[x + 2, y - 3] = 1;
                                }
                            }
                            //Si bloc à une case du bas (le baton est horizontale dans ce cas)
                            else if (y == 22)
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y] = 11;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y - 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y] = 1;
                                    map[x + 2, y - 1] = 11;
                                    map[x + 2, y - 2] = 1;
                                }
                            }
                            //Si le bloc est collé au bord gauche
                            else if (x == 0)
                            {
                                //Le point de rotation se trouve un bloc en dessous
                                if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x, y + 1] = 1;
                                    map[x + 1, y + 1] = 11;
                                    map[x + 2, y + 1] = 1;
                                    map[x + 3, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x, y + 2] = 1;
                                    map[x + 1, y + 2] = 1;
                                    map[x + 2, y + 2] = 11;
                                    map[x + 3, y + 2] = 1;
                                }
                                //Le point de rotation se trouve un bloc plus loin
                                else if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes position
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y - 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes position
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y + 2] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                            }
                            //Si le bloc est collé au bord gauche
                            else if (x == 1)
                            {
                                //Le point de rotation se trouve un bloc en dessous
                                if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 1] = 1;
                                    map[x, y + 1] = 11;
                                    map[x + 1, y + 1] = 1;
                                    map[x + 2, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 2] = 1;
                                    map[x, y + 2] = 1;
                                    map[x + 1, y + 2] = 11;
                                    map[x + 2, y + 2] = 1;
                                }
                                //Le point de rotation se trouve un bloc plus loin
                                else if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes position
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y - 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes position
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y + 2] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                            }
                            //On ne sait pas si le baton est vertical ou horizontale
                            else
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y - 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else if (map[x + 2, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 2] = 1;
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                                //Le point de rotation se trouve un bloc en dessous
                                else if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 1] = 1;
                                    map[x + 1, y + 1] = 1;
                                    map[x + 2, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 2, y + 2] = 1;
                                    map[x - 1, y + 2] = 1;
                                    map[x + 1, y + 2] = 1;
                                }
                            }
                        }
                        //On sort de la boucle
                        x = 10;
                        y = 24;
                    }
                }
            }

            return map;
        }

        //Effectue une rotation vers la droite
        public int[,] RotationDroite(int[,] map)
        {
            int x;
            int y;

            //Point de rotation = 11


            //Check toutes la valeurs du tableau
            for (y = 0; y < 24; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    //Lorsqu'un bloc est trouvé
                    if (map[x, y] == 1)
                    {
                        map[x, y] = 0;

                        //Si bloc collé au bord droite (le baton est verticale dans ce cas)
                        if (x == 9)
                        {
                            //Le point de rotation se trouve un bloc en dessous
                            if (map[x, y + 1] == 11)
                            {
                                //Suppression des anciennes positions
                                map[x, y + 2] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x, y + 1] = 1;
                                map[x - 1, y + 1] = 11;
                                map[x - 2, y + 1] = 1;
                                map[x - 3, y + 1] = 1;
                            }
                            //Le point de rotation se trouve deux blocs en dessous
                            else
                            {
                                //Suppression des anciennes positions
                                map[x, y + 1] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x, y + 2] = 1;
                                map[x - 1, y + 2] = 1;
                                map[x - 2, y + 2] = 11;
                                map[x - 3, y + 2] = 1;
                            }
                        }
                        //Si bloc à une case du bord droite (le baton est verticale dans ce cas)
                        else if (x == 8)
                        {
                            //Le point de rotation se trouve un bloc en dessous
                            if (map[x, y + 1] == 11)
                            {
                                //Suppression des anciennes positions
                                map[x, y + 2] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x + 1, y + 1] = 1;
                                map[x, y + 1] = 11;
                                map[x - 1, y + 1] = 1;
                                map[x - 2, y + 1] = 1;
                            }
                            //Le point de rotation se trouve deux blocs en dessous
                            else
                            {
                                //Suppression des anciennes positions
                                map[x, y + 1] = 0;
                                map[x, y + 3] = 0;

                                //Initialisation des nouvelles positions
                                map[x + 1, y + 2] = 1;
                                map[x, y + 2] = 1;
                                map[x - 1, y + 2] = 11;
                                map[x - 2, y + 2] = 1;
                            }
                        }
                        else
                        {
                            //Si bloc collé en bas (le baton est horizontale dans ce cas)
                            if (y == 23)
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y - 2] = 11;
                                    map[x + 1, y - 3] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y] = 1;
                                    map[x + 2, y - 1] = 11;
                                    map[x + 2, y - 2] = 1;
                                    map[x + 2, y - 3] = 1;
                                }
                            }
                            //Si bloc à une case du bas (le baton est horizontale dans ce cas)
                            else if (y == 22)
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y] = 1;
                                    map[x + 1, y - 1] = 11;
                                    map[x + 1, y - 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y] = 11;
                                    map[x + 2, y - 1] = 1;
                                    map[x + 2, y - 2] = 1;
                                }
                            }
                            //Si le bloc est collé au bord gauche
                            else if (x == 0)
                            {
                                //Le point de rotation se trouve un bloc en dessous
                                if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x, y + 1] = 1;
                                    map[x + 1, y + 1] = 1;
                                    map[x + 2, y + 1] = 11;
                                    map[x + 3, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x, y + 2] = 1;
                                    map[x + 1, y + 2] = 11;
                                    map[x + 2, y + 2] = 1;
                                    map[x + 3, y + 2] = 1;
                                }
                                //Le point de rotation se trouve un bloc plus loin
                                else if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes position
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y + 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes position
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y - 2] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                            }
                            //Si le bloc est collé au bord gauche
                            else if (x == 1)
                            {
                                //Le point de rotation se trouve un bloc en dessous
                                if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 1] = 1;
                                    map[x, y + 1] = 1;
                                    map[x + 1, y + 1] = 11;
                                    map[x + 2, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 2] = 1;
                                    map[x, y + 2] = 11;
                                    map[x + 1, y + 2] = 1;
                                    map[x + 2, y + 2] = 1;
                                }
                                //Le point de rotation se trouve un bloc plus loin
                                else if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes position
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y + 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else
                                {
                                    //Suppression des anciennes position
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y - 2] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                            }
                            //On ne sait pas si le baton est vertical ou horizontale
                            else
                            {
                                //Le point de rotation se trouve un bloc plus loin
                                if (map[x + 1, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 2, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 1, y + 1] = 1;
                                    map[x + 1, y - 1] = 1;
                                    map[x + 1, y + 2] = 1;
                                }
                                //Le point de rotation se trouve deux blocs plus loin
                                else if (map[x + 2, y] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x + 1, y] = 0;
                                    map[x + 3, y] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y - 2] = 1;
                                    map[x + 2, y + 1] = 1;
                                    map[x + 2, y - 1] = 1;
                                }
                                //Le point de rotation se trouve un bloc en dessous
                                else if (map[x, y + 1] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 2] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x - 1, y + 1] = 1;
                                    map[x + 1, y + 1] = 1;
                                    map[x - 2, y + 1] = 1;
                                }
                                //Le point de rotation se trouve deux blocs en dessous
                                else if (map[x, y + 2] == 11)
                                {
                                    //Suppression des anciennes positions
                                    map[x, y + 1] = 0;
                                    map[x, y + 3] = 0;

                                    //Initialisation des nouvelles positions
                                    map[x + 2, y + 2] = 1;
                                    map[x - 1, y + 2] = 1;
                                    map[x + 1, y + 2] = 1;
                                }
                            }
                        }
                        //On sort de la boucle
                        x = 10;
                        y = 24;
                    }
                }
            }

            return map;
        }
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
