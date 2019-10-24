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
        /// <summary>
        /// Blocks spawning new cube until latest arrives
        /// </summary>
        public bool candrop = false;
        #endregion

        #region Methods
        /// <summary>
        /// Method: Adding new element and adding it to the form
        /// </summary>
        public void CreatingNewBlock()
        {
            TowerClass.NewBlock();
            Controls.Add(TowerClass.LastBlock);
        }
        /// <summary>
        /// amount to move camera by (used by animation)
        /// </summary>
        public int cameraMovementAmount;
        /// <summary>
        /// Triggers a camera movement event
        /// <paramref name="numberOfBlocks"/>
        /// number of blocks to move the camera by
        /// </summary>
        /// <param name="numberOfBlocks"></param>
        public void moveCamera(int numberOfBlocks)
        {
             cameraMovementAmount = TowerClass.Blocks[0].Height * numberOfBlocks;
             cameraMovementTimer.Enabled = true;
        }

        /// <summary>
        /// Method: Dropping the given element, checking the dropped one
        /// </summary>
        public void DroppingNewBlock()
        {
            TowerClass.Drop();
            bool notFirstBlock = TowerClass.NumberOfBlocks > 0;
            // first block cannot be missed
            TowerClass.Missed = notFirstBlock && TowerClass.BadlyDropped();
            if (!TowerClass.Missed) TowerClass.NumberOfBlocks += 1;

            const int NUMBER_OF_BLOCKS = 2;
            if (TowerClass.NumberOfBlocks > 3 && TowerClass.NumberOfBlocks % NUMBER_OF_BLOCKS == 0)
            {
                moveCamera(NUMBER_OF_BLOCKS);
            }
        }
        #endregion

        #region Program's activity

        /// <summary>
        /// amount to count down - full
        /// </summary>
        public const int TIME_TO_START_INITIAL = 3;
        /// <summary>
        /// amount left of count down - current
        /// </summary>
        public int timeToStart = TIME_TO_START_INITIAL;
        /// <summary>
        /// Countdown, the place where we invite the class (Block)
        /// </summary>
        public void Start_timer_Tick(object sender, EventArgs e)
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
        public void Loop_timer_Tick(object sender, EventArgs e)
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

        /// <summary>
        /// Handler for dropping by space
        /// </summary>
        public void Game_Clicks(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                EventArgs a = new EventArgs();
                Game_Click(sender, a);
            }
        }

        /// <summary>
        /// Handler for animated camera movement
        /// </summary>
        public void cameraMovementTimer_Tick(object sender, EventArgs e)
        {
            int currentCamMoveAmount = Math.Min(10, cameraMovementAmount);
            if (cameraMovementAmount <= 0)
            {
                cameraMovementTimer.Enabled = false;
            }
            else
            {
                cameraMovementAmount -= currentCamMoveAmount;
                TowerClass.Height += currentCamMoveAmount;
                for (int i = 0; i < TowerClass.NumberOfBlocks; i++)
                {
                    TowerClass.Blocks[i].Top += currentCamMoveAmount;
                }
                lbGround.Top += currentCamMoveAmount;
            }
        }
        #endregion
    }
}
