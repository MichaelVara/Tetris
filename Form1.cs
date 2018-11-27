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
    public partial class Menu : Form
    {
        #region private attributes
        private frmJeu _frmGame;
        #endregion private attributes

        #region constructors
        public Menu()
        {
            InitializeComponent();
        }
        #endregion constructors

        #region accessors and mutators
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods

        //Le texte devient argente lors du passage de la souris
        private void TxtPlay_MouseEnter(object sender, EventArgs e)
        {
            TxtPlay.ForeColor = Color.Silver;
        }

        //Le texte redevient normal lorsque la souris quitte le texte
        private void TxtPlay_MouseLeave(object sender, EventArgs e)
        {
            TxtPlay.ForeColor = Color.White;
        }

        //Charger le jeu lorsque le joueur clique sur Jouer
        private void TxtPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmGame = new frmJeu();
            _frmGame.Show();

            //Evenement actif lors de la fermeture de jeu
            frmJeu.ActiveForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJeu_FormClosing);
        }

        //Affiche le menu a nouveau lorsque le jeu se ferme
        private void FrmJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        #endregion private methods
    }
}
