using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TowerBlocks
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        #region Fields
        Block TowerClass;
        Updates updates = new Updates();
        private bool candrop = true;
        #endregion

        #region Methods
        /// <summary>
        /// Method: Adding new element and adding it to the form
        /// </summary>
        private void CreatingNewBlock()
        {
            TowerClass.NewBlock();
            Controls.Add(TowerClass.LastBlock);
        }
        /// <summary>
        /// Method: Dropping the given element, checking the dropped one
        /// </summary>
        private void DroppingNewBlock()
        {
            TowerClass.Drop();
            bool notFirstBlock = TowerClass.NumberOfBlocks > 0;
            // first block cannot be missed
            TowerClass.Missed = notFirstBlock && TowerClass.BadlyDropped();
            if (!TowerClass.Missed) TowerClass.NumberOfBlocks += 1;
        }
        #endregion

        #region Program's activity

        private const int TIME_TO_START_INITIAL = 3;
        private int timeToStart = TIME_TO_START_INITIAL;
        /// <summary>
        /// Countdown, the place where we invite the class (Block)
        /// </summary>
        private void Start_timer_Tick(object sender, EventArgs e)
        {
            label_start.Visible = true;
            timeToStart -= 1;
            if (timeToStart == 0)
            {
                start_timer.Stop();
                loop_timer.Start();
                timeToStart = TIME_TO_START_INITIAL;
                label_start.Visible = false;
                TowerClass = new Block();
            }
            label_start.Text = timeToStart + "";
        }

        /// <summary>
        /// Slithering the given block
        /// </summary>
        private void Loop_timer_Tick(object sender, EventArgs e)
        {
            candrop = true;
            if (TowerClass.NotYetCreatedFirstBlock)
            {
                CreatingNewBlock();
                TowerClass.Height = Height - TowerClass.LastBlock.Height;
                TowerClass.NotYetCreatedFirstBlock = false;
            }
            TowerClass.LastBlock.Left += TowerClass.Speed;
            if (TowerClass.LastBlock.Left <= 200 | TowerClass.LastBlock.Left >= 500)
            {
                TowerClass.Speed *= -1;
            }

        }
        
        /// <summary>
        /// Building the tower
        /// </summary>
        private void bu_Build_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private void Game_Click(object sender, EventArgs e)
        {
            if (candrop == true)
            {
                candrop = false;
                loop_timer.Stop();
                DroppingNewBlock();
                if (TowerClass.Missed)
                {
                    MessageBox.Show("You missed that one...", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                else
                {
                    updates.Load();
                    updates.money += 2;
                    updates.save();
                    CreatingNewBlock();
                    loop_timer.Start();

                }
            }
        }

        private void Game_Clicks(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                EventArgs a = new EventArgs();
                Game_Click(sender, a);
            }
        }
    }
}
