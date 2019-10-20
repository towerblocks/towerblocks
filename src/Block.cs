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
        #region Fields
        private const string ImageFile = "../../images/towerblock.png";
        /// <summary>
        /// A list where all blocks're stored
        /// </summary>
        public List<PictureBox> Blocks { get; set; }
        public int n { get; set; }
        public int Height { get; set; }
        /// <summary>
        /// It's true if the block's not dropped well
        /// </summary>
        public bool Missed { get; set; }
        /// <summary>
        /// After the first block's dropped, it'll be false
        /// </summary>
        public bool WasThereFirstBlock { get; set; }
        public int Speed;
        #endregion

        /// <summary>
        /// Setting everything defaulted
        /// </summary>
        public Block()
        {
            Blocks = new List<PictureBox>();
            n = 0;
            Missed = false;
            WasThereFirstBlock = true;
            Speed = 8;
        }

        /// <summary>
        /// Adding a new element to the list
        /// </summary>
        /// <param name="Tomb">Parameter</param>
        public void NewBlock()
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
            Blocks.Add(Variable);
        }

        /// <summary>
        /// Dropping an given element
        /// </summary>
        public void Drop()
        {
            while (Blocks[n].Top+Blocks[n].Height<Height)
            {
                Blocks[n].Top += 5;
                Thread.Sleep(7);
            }
            Height -= Blocks[n].Height;
            
        }

        /// <summary>
        /// Seeing if the given block's been badly dropped, if it's badly dropped -> returns "true"
        /// </summary>
        public bool BadlyDropped()
        {
            if (Blocks[n].Left-Blocks[n-1].Left>50 || Blocks[n].Left-Blocks[n-1].Left<-50)
            {
                return true;
            }
            n++;
            return false;
            
        }
    }
}
