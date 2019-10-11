using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerBlocks
{
    public partial class Menu : Form
    {
        private Game gameWindow;
        public Menu()
        {
            InitializeComponent();
        }

        private void Bu_start_Click(object sender, EventArgs e)
        {
            gameWindow = new Game();
            gameWindow.Show();
            Hide();
            gameWindow.FormClosed += GameWindow_FormClosed;
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
