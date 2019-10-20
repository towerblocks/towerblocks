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
using System.Threading;

namespace TowerBlocks
{
    class Block
    {
        private const string ImageFile = "../../images/towerblock.png";
        public int Height { get; set; }

        /// <summary>
        /// Adding a new element to the list
        /// </summary>
        /// <param name="Tomb">Parameter</param>
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

        /// <summary>
        /// Dropping an element from the list
        /// </summary>
        public void Drop(List<PictureBox> Tomb, int n)
        {
            while (Tomb[n].Top+Tomb[n].Height<Height)
            {
                Tomb[n].Top += 5;
                Thread.Sleep(7);
            }
            Height -= Tomb[n].Height;
            
        }

        /// <summary>
        /// Seeing if the block's been badly dropped, if it's badly dropped -> returns "true"
        /// </summary>
        public bool BadlyDropped(List<PictureBox> Tomb, ref int n)
        {
            if (Tomb[n].Left-Tomb[n-1].Left>50 || Tomb[n].Left-Tomb[n-1].Left<-50)
            {
                return true;
            }
            n++;
            return false;
            
        }
    }
}
