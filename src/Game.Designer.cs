namespace TowerBlocks
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.start_timer = new System.Windows.Forms.Timer(this.components);
            this.label_start = new System.Windows.Forms.Label();
            this.loop_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "score:";
            // 
            // start_timer
            // 
            this.start_timer.Enabled = true;
            this.start_timer.Interval = 1000;
            this.start_timer.Tick += new System.EventHandler(this.Start_timer_Tick);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(321, 191);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(80, 13);
            this.label_start.TabIndex = 2;
            this.label_start.Text = "START TIMER";
            // 
            // loop_timer
            // 
            this.loop_timer.Interval = 20;
            this.loop_timer.Tick += new System.EventHandler(this.Loop_timer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.blockDroped);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer start_timer;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Timer loop_timer;
    }
}