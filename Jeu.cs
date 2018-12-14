using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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

        private GestionForme _gestionforme;
        private PictureBox[,] _map;
        #endregion private attributes

        #region constructors
        public frmJeu()
        {
            InitializeComponent();

            //Réinitialisation des variables
            _nextForme = null;
            InitialiseImages();


            //Désigne la prochaine forme
            _nextForme = NextForme();

            string formeRandom;

            //Pour que la forme actuelle soit différente de la prochaine
            do
            {
                //Random parmis toutes les formes dispo
                _forme f = (_forme)(new Random()).Next(0, 7);
                formeRandom = f.ToString();
            } while (formeRandom == _nextForme);

            _gestionforme = new GestionForme();

            //Ajout de la forme actuelle
            _gestionforme.NouvelleForme("baton");

            //Dessine la forme actuelle
            DessinerForme();
        }
        #endregion constructors

        #region accessors and mutators
        #endregion accessors and mutators

        #region public methods
        #endregion public methods

        #region private methods
        private string NextForme()
        {
            //On cache la forme précédente
            switch (_nextForme)
            {
                case "baton":
                    this.ptbNextBaton.Hide();
                    break;

                case "cube":
                    this.ptbNextCube.Hide();
                    break;

                case "l1":
                    this.ptbNextL1.Hide();
                    break;

                case "l2":
                    this.ptbNextL2.Hide();
                    break;

                case "s":
                    this.ptbNextS.Hide();
                    break;

                case "t":
                    this.ptbNextT.Hide();
                    break;

                case "z":
                    this.ptbNextZ.Hide();
                    break;
            }

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

        //Initialise toutes les picturebox de la map
        private void InitialiseImages()
        {
            int x;
            int y;

            _map = new PictureBox[10, 20];

            //Pour chaque case de la map
            for (y = 0; y < 20; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    _map[x, y] = new PictureBox();
                        
                    //Initialisation des propriétés de l'image
                    _map[x, y].Location = new Point(36 * x + 48, 36 * y + 77);
                    _map[x, y].Size = new Size(36, 36);
                    _map[x, y].SizeMode = PictureBoxSizeMode.Normal;
                    this.Controls.Add(_map[x, y]);
                }
            }
        }

        //Dessine la forme actuel
        private void DessinerForme()
        {
            //On vérifie s'il y a besoin d'une nouvelle forme
            if (_gestionforme.nouvellePiece())
            {

                _gestionforme.NouvelleForme(_nextForme);

                _nextForme = NextForme();
            }


            int x;
            int y;

            //Pour chaque case de la map
            for (y = 4; y < 24; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    //S'il y a un bloc
                    if (_gestionforme.map()[x,y] > 0)
                    {
                        //Sélectionne le bon bloc en fonction de la forme
                        switch (_gestionforme.map()[x,y])
                        {
                            case 1:
                            case 11:
                            case 21:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksBaton;
                                break;

                            case 2:
                            case 12:
                            case 22:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksCube;
                                break;

                            case 3:
                            case 13:
                            case 23:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksL1;
                                break;

                            case 4:
                            case 14:
                            case 24:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksL2;
                                break;

                            case 5:
                            case 15:
                            case 25:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksS;
                                break;

                            case 6:
                            case 16:
                            case 26:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksT;
                                break;

                            case 7:
                            case 17:
                            case 27:
                                _map[x, y - 4].Image = Tetris.Properties.Resources.TetrisBlocksZ;
                                break;
                        }
                    }
                    else
                    {
                        _map[x, y - 4].Image = null;
                    }
                }
            }
        }

        //Lorsque l'utilisateur appuie sur une touche
        private void frmJeu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _gestionforme.DeplacementForme("gauche");
                    DessinerForme();
                    break;

                case Keys.Right:
                    _gestionforme.DeplacementForme("droite");
                    DessinerForme();
                    break;

                case Keys.Up:
                    _gestionforme.DeplacementForme("haut");
                    DessinerForme();
                    break;

                case Keys.Down:
                    _gestionforme.DeplacementForme("bas");
                    DessinerForme();
                    break;

                case Keys.A:
                    _gestionforme.DeplacementForme("a");
                    DessinerForme();
                    break;

                case Keys.D:
                    _gestionforme.DeplacementForme("d");
                    DessinerForme();
                    break;
            }
        }
        #endregion private methods
    }
}
