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
        private const string IMAGE_FILE_PATH = "../../images/towerblock.png";
        /// <summary>
        /// A list where all blocks're stored
        /// </summary>
        public List<PictureBox> Blocks { get; set; }
        /// <summary>
        /// The block latest created
        /// !notice it can reference a block in 2 states:
        /// in the air and
        /// on the top of the tower
        /// </summary>
        public PictureBox LastBlock
        {
            get { return Blocks[NumberOfBlocks]; }
        }
        public int NumberOfBlocks { get; set; }
        public int Height { get; set; }
        /// <summary>
        /// It's true if the block's not dropped well
        /// </summary>
        public bool Missed { get; set; }
        /// <summary>
        /// After the first block's dropped, it'll be false
        /// </summary>
        public bool NotYetCreatedFirstBlock { get; set; }
        public int Speed;
        #endregion

        /// <summary>
        /// Setting everything defaulted
        /// </summary>
        public Block()
        {
            Blocks = new List<PictureBox>();
            NumberOfBlocks = 0;
            Missed = false;
            NotYetCreatedFirstBlock = true;
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
            Variable.Image = Image.FromFile(IMAGE_FILE_PATH);
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
            while (LastBlock.Top + LastBlock.Height < Height)
            {
                LastBlock.Top += 5;
                Thread.Sleep(7);
            }
            Height -= LastBlock.Height;
            
        }

        /// <summary>
        /// Seeing if the given block's been badly dropped, if it's badly dropped -> returns "true"
        /// </summary>
        public bool BadlyDropped()
        {
            const int LIMIT_OF_X_DIFF = 50;
            int currentLeft = LastBlock.Left;
            int prevLeft = Blocks[NumberOfBlocks - 1].Left;

            return Math.Abs(currentLeft - prevLeft) > LIMIT_OF_X_DIFF;
        }
    }
}
