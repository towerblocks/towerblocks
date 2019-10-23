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
            Money_label.Text = "Money: " + Update.money.ToString();
            Block_Update.Text = "Update Block \n" + (Update.blocklevel * Update.blocklevel * 15).ToString();
            Speed_Update.Text = "Update Speed \n" + (Update.speedlevel * Update.speedlevel * 15).ToString();
            Level_update.Text = "Update Level \n" + (Update.level * Update.level * 200).ToString();
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
            if (Update.money > Update.blocklevel * Update.blocklevel * 15)
            {
                Update.money -= Update.blocklevel * Update.blocklevel * 15;
                Update.blocklevel += 1;
                Update.save();
                Block_label.Text = "Level: " + Update.blocklevel.ToString();
                Money_label.Text = "Money: " + Update.money.ToString();
                Block_Update.Text = "Update Block \n" + (Update.blocklevel * Update.blocklevel * 15).ToString();
            }
        }

        private void Speed_Update_Click(object sender, EventArgs e)
        {
            if (Update.money > Update.speedlevel * Update.speedlevel * 15)
            {
                Update.money -= Update.speedlevel * Update.speedlevel * 15;
                Update.speedlevel += 1;
                Update.save();
                Speed_label.Text = "Level: " + Update.speedlevel.ToString();
                Money_label.Text = "Money: " + Update.money.ToString();
                Speed_Update.Text = "Update Speed \n" + (Update.speedlevel * Update.speedlevel * 15).ToString();
            }
        }

        private void Level_update_Click(object sender, EventArgs e)
        {
            if (Update.money > Update.level * Update.level * 200)
            {
                Update.money -= Update.level * Update.level * 200;
                Update.level += 1;
                Update.save();
                Level_label.Text = "Level: " + Update.level.ToString();
                Money_label.Text = "Money: " + Update.money.ToString();
                Level_update.Text = "Update Level \n" + (Update.level * Update.level * 15).ToString();
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            Update.Load();
            Speed_label.Text = "Level: " + Update.speedlevel.ToString();
            Block_label.Text = "Level: " + Update.blocklevel.ToString();
            Level_label.Text = "Level: " + Update.level.ToString();
            Money_label.Text = "Money: " + Update.money.ToString();
            Block_Update.Text = "Update Block \n" + (Update.blocklevel * Update.blocklevel * 15).ToString();
            Speed_Update.Text = "Update Speed \n" + (Update.speedlevel * Update.speedlevel * 15).ToString();
            Level_update.Text = "Update Level \n" + (Update.level * Update.level * 200).ToString();
        }
    }
}
