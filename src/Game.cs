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
        //new
        Block classBlock;
        List<PictureBox> Blocks;
        private int Speed = 8;
        private int n;
        bool FirstBlock;

        private void CreatingNewBlock(List<PictureBox>Tomb, int p_n)
        {
            classBlock.NewBlock(Tomb);
            Controls.Add(Tomb[p_n]);
        }

        private const int TIME_TO_START_INITIAL = 3;
        private int timeToStart = TIME_TO_START_INITIAL;
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
                //new
                n = 0;
                classBlock = new Block();
                Blocks = new List<PictureBox>();
            }
            label_start.Text = timeToStart + "";
        }

        private void Loop_timer_Tick(object sender, EventArgs e)
        {
            // TODO: add loop logic here
            bu_Build.Enabled = true;
            if (FirstBlock)
            {
                CreatingNewBlock(Blocks, n);
            }
            FirstBlock = false;
            Blocks[n].Left += Speed;
            if (Blocks[n].Left <= 200 | Blocks[n].Left >= 500)
            {
                Speed *= -1;
            }

        }

        private void blockDroped(object sender, KeyEventArgs e)
        {


            /*
            if (Dropping)
            {
                Blocks.ElementAt(0).Visible = true;
                loop_timer.Start();
                Dropping = false;
            }
            else
            {
                while (Blocks.ElementAt(n).Top+80<t)
                {
                    Blocks.ElementAt(n).Top += 5;
                    Thread.Sleep(7);
                }
                if (n>0 && (Blocks.ElementAt(n).Left-OldLeftEq>50 || Blocks.ElementAt(n).Left-OldLeftEq<-50))
                {
                    loop_timer.Stop();
                }
                OldLeftEq = Blocks.ElementAt(n).Left;
                n++;
                t -= 80;
            }*/
         
        }

        private void Game_Load(object sender, EventArgs e)
        {
            FirstBlock = true;
        }

        private void bu_Build_Click(object sender, EventArgs e)
        {
            loop_timer.Stop();
            bu_Build.Enabled = false;
            classBlock.Drop(ref Blocks, ref n);
            CreatingNewBlock(Blocks, n);
            loop_timer.Start();
        }
    }
}
