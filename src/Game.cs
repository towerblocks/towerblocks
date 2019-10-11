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

        private int timeToStart = 3;
        private void Start_timer_Tick(object sender, EventArgs e)
        {
            timeToStart -= 1;
            label_start.Text = timeToStart + "";
        }
    }
}
