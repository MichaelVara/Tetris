using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class FormeL1
    {
        #region privates attributes
        #endregion privates attributes

        #region constructor
        #endregion constructor

        #region accessors and mutators
        //Initialise les positions de base
        public int[,] Initialise(int[,] map)
        {
            map[4, 3] = 3;
            map[5, 3] = 13;
            map[6, 3] = 3;
            map[6, 2] = 3;

            return map;
        }

        //Effectue une rotation vers la gauche
        public int[,] RotationGauche(int[,] map)
        {
            return map;
        }

        //Effectue une rotation vers la droite
        public int[,] RotationDroite(int[,] map)
        {
            return map;
        }
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
