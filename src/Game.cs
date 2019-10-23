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
        Updates Update = new Updates();
        #endregion

        #region Methods
        /// <summary>
        /// Method: Adding new element and adding it to the form
        /// </summary>
        private void CreatingNewBlock()
        {
            TowerClass.NewBlock();
            Controls.Add(TowerClass.Blocks[TowerClass.n]);
        }
        /// <summary>
        /// Method: Dropping the given element, checking the dropped one
        /// </summary>
        private void DroppingNewBlock()
        {
            TowerClass.Drop();
            if (TowerClass.n>0)
            {
                if (TowerClass.BadlyDropped())
                {
                    TowerClass.Missed = true;
                }
                else
                TowerClass.Missed = false;
            }
            else
            {
                TowerClass.Missed = false;
                TowerClass.n++;
            }
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
            bu_Build.Enabled = true;
            if (TowerClass.WasThereFirstBlock)
            {
                CreatingNewBlock();
                TowerClass.Height = Height - TowerClass.Blocks[TowerClass.n].Height;
            }
            TowerClass.WasThereFirstBlock = false;
            TowerClass.Blocks[TowerClass.n].Left += TowerClass.Speed;
            if (TowerClass.Blocks[TowerClass.n].Left <= 200 | TowerClass.Blocks[TowerClass.n].Left >= 500)
            {
                TowerClass.Speed *= -1;
            }

        }

        private void blockDropped(object sender, KeyEventArgs e)
        {
            
        }
        
        /// <summary>
        /// Building the tower
        /// </summary>
        private void bu_Build_Click(object sender, EventArgs e)
        {
            loop_timer.Stop();
            bu_Build.Enabled = false;
            DroppingNewBlock();
            if (TowerClass.Missed)
            {
                MessageBox.Show("You missed that one...", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                Update.Load();
                Update.money += 15;
                Update.save();
                CreatingNewBlock();
                loop_timer.Start();
            }
        }

        #endregion
    }
}
