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
        Block classBlock;
        /// <summary>
        /// A list where all blocks're stored
        /// </summary>
        List<PictureBox> Blocks;
        private int Speed = 8;
        private int n;
        bool FirstBlock;
        private bool Missed;
        #endregion

        #region Methods
        /// <summary>
        /// Method: Adding new element and making it visible
        /// </summary>
        private void CreatingNewBlock(List<PictureBox>Tomb, int p_n)
        {
            classBlock.NewBlock(Tomb);
            Controls.Add(Tomb[p_n]);
        }
        /// <summary>
        /// Method: Dropping the new element, checking the dropped one
        /// </summary>
        private void DroppingNewBlock(List<PictureBox>Tomb, ref int p_n, ref bool LogO)
        {
            classBlock.Drop(Tomb, p_n);
            if (n>0)
            {
                if (classBlock.BadlyDropped(Tomb, ref p_n))
                {
                    LogO = true;
                }
                else
                LogO = false;
            }
            else
            {
                LogO = false;
                n++;
            }
        }
        #endregion

        #region Program's activity

        private const int TIME_TO_START_INITIAL = 3;
        private int timeToStart = TIME_TO_START_INITIAL;
        /// <summary>
        /// After a countdown, it makes a new class and a new list, with n=0
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
                n = 0;
                classBlock = new Block();
                Blocks = new List<PictureBox>();
            }
            label_start.Text = timeToStart + "";
        }

        /// <summary>
        /// Slithering the new block
        /// </summary>
        private void Loop_timer_Tick(object sender, EventArgs e)
        {
            bu_Build.Enabled = true;
            if (FirstBlock)
            {
                CreatingNewBlock(Blocks, n);
                classBlock.Height = Height - Blocks[n].Height;
            }
            FirstBlock = false;
            Blocks[n].Left += Speed;
            if (Blocks[n].Left <= 200 | Blocks[n].Left >= 500)
            {
                Speed *= -1;
            }

        }

        private void blockDropped(object sender, KeyEventArgs e)
        {
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            FirstBlock = true;
        }
        
        private void bu_Build_Click(object sender, EventArgs e)
        {
            loop_timer.Stop();
            bu_Build.Enabled = false;
            DroppingNewBlock(Blocks, ref n, ref Missed);
            if (Missed)
            {
                MessageBox.Show("You missed that one...", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                CreatingNewBlock(Blocks, n);
                loop_timer.Start();
            }
        }

        #endregion
    }
}
