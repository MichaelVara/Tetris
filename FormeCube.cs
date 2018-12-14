using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class FormeCube
    {
        #region privates attributes
        #endregion privates attributes

        #region constructor
        #endregion constructor

        #region accessors and mutators
        //Initialise les positions de base
        public int[,] Initialise(int[,] map)
        {
            map[4, 2] = 2;
            map[5, 2] = 2;
            map[4, 3] = 2;
            map[5, 3] = 2;
            return map;
        }
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
