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
        Updates Update = new Updates();
        public Menu()
        {
            InitializeComponent();
            bool loaded = Update.Load();
            Speed_label.Text = "Level: " + Update.speedlevel.ToString();
            Block_label.Text = "Level: " + Update.blocklevel.ToString();
            Level_label.Text = "Level: " + Update.level.ToString();
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Block_Update_Click(object sender, EventArgs e)
        {
            Update.blocklevel += 1;
            Update.save();
            Block_label.Text = "Level: " + Update.blocklevel.ToString();
        }

        private void Speed_Update_Click(object sender, EventArgs e)
        {
            Update.speedlevel += 1;
            Update.save();
            Speed_label.Text = "Level: " + Update.speedlevel.ToString();
        }

        private void Level_update_Click(object sender, EventArgs e)
        {
            Update.level += 1;
            Update.save();;
            Level_label.Text = "Level: " + Update.level.ToString();
        }
    }
}
