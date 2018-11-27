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
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TxtPlay_MouseEnter(object sender, EventArgs e)
        {
            TxtPlay.ForeColor = Color.Silver;
        }

        private void TxtPlay_MouseLeave(object sender, EventArgs e)
        {
            TxtPlay.ForeColor = Color.White;
        }

        private void TxtPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
