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
        private const string ImageFile = "../../images/towerblock.png";

        public void NewBlock(List<PictureBox> Tomb)
        {
            PictureBox Variable;
            Variable = new PictureBox();
            Variable.Parent = Game.ActiveForm;
            Variable.Image = Image.FromFile(ImageFile);
            Variable.Left = 350;
            Variable.Top = 0;
            Variable.Height = 80;
            Variable.Width = 100;
            Variable.Visible = true;
            Tomb.Add(Variable);
        }
    }
}
