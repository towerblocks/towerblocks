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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
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
            }
            label_start.Text = timeToStart + "";
        }


        private void Loop_timer_Tick(object sender, EventArgs e)
        {
            // TODO: add loop logic here
        }

        private void blockDroped(object sender, KeyEventArgs e)
        {

        }
    }
}
