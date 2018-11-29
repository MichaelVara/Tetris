using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmJeu : Form
    {
        #region private attributes
        //Énumération des différentes formes
        private enum _forme
        {
            baton,
            cube,
            l1,
            l2,
            s,
            t,
            z
        }

        private string _nextForme = null;
        private string _formeActuel = null;
        #endregion private attributes

        #region constructors
        public frmJeu()
        {
            InitializeComponent();

            //Désigne la prochaine forme
            _nextForme = NextForme();

            //Pour que la forme actuelle soit différente de la prochaine
            do
            {
                //Random parmis toutes les formes dispo
                _forme f = (_forme)(new Random()).Next(0, 7);
                _formeActuel = f.ToString();
            } while (_formeActuel == _nextForme);
        }
        #endregion constructors

        #region accessors and mutators
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods
        private string NextForme()
        {
            //Random parmis toutes les formes dispo
            _forme f = (_forme)(new Random()).Next(0, 7);

            //Affichage de la prochaine forme dans la case "Next"
            switch(f)
            {
                case _forme.baton:
                    this.ptbNextBaton.Show();
                    break;

                case _forme.cube:
                    this.ptbNextCube.Show();
                    break;

                case _forme.l1:
                    this.ptbNextL1.Show();
                    break;

                case _forme.l2:
                    this.ptbNextL2.Show();
                    break;

                case _forme.s:
                    this.ptbNextS.Show();
                    break;

                case _forme.t:
                    this.ptbNextT.Show();
                    break;

                case _forme.z:
                    this.ptbNextZ.Show();
                    break;
            }

            return f.ToString();
        }
        #endregion private methods
    }
}
