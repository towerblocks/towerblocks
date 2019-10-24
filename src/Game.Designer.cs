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
            this.lbGround = new System.Windows.Forms.Label();
            this.cameraMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
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
            this.label_start.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_start.Location = new System.Drawing.Point(12, 262);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(766, 117);
            this.label_start.TabIndex = 2;
            this.label_start.Text = "The game starts now";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loop_timer
            // 
            this.loop_timer.Interval = 20;
            this.loop_timer.Tick += new System.EventHandler(this.Loop_timer_Tick);
            // 
            // lbGround
            // 
            this.lbGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbGround.Location = new System.Drawing.Point(175, 878);
            this.lbGround.Name = "lbGround";
            this.lbGround.Size = new System.Drawing.Size(426, 40);
            this.lbGround.TabIndex = 4;
            // 
            // cameraMovementTimer
            // 
            this.cameraMovementTimer.Interval = 10;
            this.cameraMovementTimer.Tick += new System.EventHandler(this.cameraMovementTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 918);
            this.Controls.Add(this.lbGround);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TowerBlock";
            this.Click += new System.EventHandler(this.Game_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Clicks);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer start_timer;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Timer loop_timer;
        private System.Windows.Forms.Label lbGround;
       // private System.Windows.Forms.Timer cameraMovement_timer;
        private System.Windows.Forms.Timer cameraMovementTimer;
    }
}