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
        List<Block> Blocks;
        private int Speed = 6;
        private int n;

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
                Blocks = new List<Block>();
                n = 0;
            }
            label_start.Text = timeToStart + "";
        }

        private void Loop_timer_Tick(object sender, EventArgs e)
        {
            // TODO: add loop logic here
            
            Blocks.Add(new Block());
            Blocks.ElementAt(n).Left += Speed;
            if (Blocks.ElementAt(n).Left <= 200 | Blocks.ElementAt(n).Left >= 500)
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
        
    }
}
