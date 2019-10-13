using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TowerBlocks
{
    class Block
    {
        private const string ImageFile = "../images/towerblock.png";
        public int Left { get; internal set; }
        public Control Parent { get; set; }
        public string ImageLocation { get; set; }
        public int Top { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
        public Image Img { get; set; }

        public Block()
        {
            Left = 350;
            Parent = Game.ActiveForm;
            Img = Image.FromFile("D:/Martin/Iskola/Programozás/github/towerblocks/src/images/towerblock.png");
            Top = 0;
            Height = 80;
            Width = 100;
            Visible = true;
        }
    }
}
