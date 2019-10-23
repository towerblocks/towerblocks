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
        Updates updates = new Updates();
        public Menu()
        {
            InitializeComponent();
            bool loaded = updates.Load();
            Speed_label.Text = "Level: " + updates.speedlevel.ToString();
            Block_label.Text = "Level: " + updates.blocklevel.ToString();
            Level_label.Text = "Level: " + updates.level.ToString();
            Money_label.Text = "Money: " + updates.money.ToString();
            Block_Update.Text = "Update Block \n" + (updates.blocklevel * updates.blocklevel * 15).ToString();
            Speed_Update.Text = "Update Speed \n" + (updates.speedlevel * updates.speedlevel * 15).ToString();
            Level_update.Text = "Update Level \n" + (updates.level * updates.level * 200).ToString();
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
            if (updates.money > updates.blocklevel * updates.blocklevel * 15)
            {
                updates.money -= updates.blocklevel * updates.blocklevel * 15;
                updates.blocklevel += 1;
                updates.save();
                Block_label.Text = "Level: " + updates.blocklevel.ToString();
                Money_label.Text = "Money: " + updates.money.ToString();
                Block_Update.Text = "Update Block \n" + (updates.blocklevel * updates.blocklevel * 15).ToString();
            }
        }

        private void Speed_Update_Click(object sender, EventArgs e)
        {
            if (updates.money > updates.speedlevel * updates.speedlevel * 15)
            {
                updates.money -= updates.speedlevel * updates.speedlevel * 15;
                updates.speedlevel += 1;
                updates.save();
                Speed_label.Text = "Level: " + updates.speedlevel.ToString();
                Money_label.Text = "Money: " + updates.money.ToString();
                Speed_Update.Text = "Update Speed \n" + (updates.speedlevel * updates.speedlevel * 15).ToString();
            }
        }

        private void Level_update_Click(object sender, EventArgs e)
        {
            if (updates.money > updates.level * updates.level * 200)
            {
                updates.money -= updates.level * updates.level * 200;
                updates.level += 1;
                updates.save();
                Level_label.Text = "Level: " + updates.level.ToString();
                Money_label.Text = "Money: " + updates.money.ToString();
                Level_update.Text = "Update Level \n" + (updates.level * updates.level * 15).ToString();
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            updates.Load();
            Speed_label.Text = "Level: " + updates.speedlevel.ToString();
            Block_label.Text = "Level: " + updates.blocklevel.ToString();
            Level_label.Text = "Level: " + updates.level.ToString();
            Money_label.Text = "Money: " + updates.money.ToString();
            Block_Update.Text = "Update Block \n" + (updates.blocklevel * updates.blocklevel * 15).ToString();
            Speed_Update.Text = "Update Speed \n" + (updates.speedlevel * updates.speedlevel * 15).ToString();
            Level_update.Text = "Update Level \n" + (updates.level * updates.level * 200).ToString();
        }
    }
}
