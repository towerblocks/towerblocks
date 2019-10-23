namespace TowerBlocks
{
    partial class Menu
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
            this.bu_start = new System.Windows.Forms.Button();
            this.bu_options = new System.Windows.Forms.Button();
            this.Block_Update = new System.Windows.Forms.Button();
            this.Speed_Update = new System.Windows.Forms.Button();
            this.Level_update = new System.Windows.Forms.Button();
            this.Block_label = new System.Windows.Forms.Label();
            this.Speed_label = new System.Windows.Forms.Label();
            this.Level_label = new System.Windows.Forms.Label();
            this.Money_label = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bu_start
            // 
            this.bu_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bu_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bu_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bu_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bu_start.Location = new System.Drawing.Point(316, 105);
            this.bu_start.Name = "bu_start";
            this.bu_start.Size = new System.Drawing.Size(127, 44);
            this.bu_start.TabIndex = 0;
            this.bu_start.Text = "START";
            this.bu_start.UseVisualStyleBackColor = false;
            this.bu_start.Click += new System.EventHandler(this.Bu_start_Click);
            // 
            // bu_options
            // 
            this.bu_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bu_options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bu_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bu_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_options.Location = new System.Drawing.Point(316, 171);
            this.bu_options.Name = "bu_options";
            this.bu_options.Size = new System.Drawing.Size(127, 44);
            this.bu_options.TabIndex = 1;
            this.bu_options.Text = "OPTIONS";
            this.bu_options.UseVisualStyleBackColor = false;
            // 
            // Block_Update
            // 
            this.Block_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Block_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Block_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Block_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Block_Update.Location = new System.Drawing.Point(121, 291);
            this.Block_Update.Name = "Block_Update";
            this.Block_Update.Size = new System.Drawing.Size(127, 86);
            this.Block_Update.TabIndex = 2;
            this.Block_Update.Text = "Update Block";
            this.Block_Update.UseVisualStyleBackColor = false;
            this.Block_Update.Click += new System.EventHandler(this.Block_Update_Click);
            // 
            // Speed_Update
            // 
            this.Speed_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Speed_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Speed_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Speed_Update.Location = new System.Drawing.Point(316, 291);
            this.Speed_Update.Name = "Speed_Update";
            this.Speed_Update.Size = new System.Drawing.Size(127, 86);
            this.Speed_Update.TabIndex = 3;
            this.Speed_Update.Text = "Update Speed";
            this.Speed_Update.UseVisualStyleBackColor = false;
            this.Speed_Update.Click += new System.EventHandler(this.Speed_Update_Click);
            // 
            // Level_update
            // 
            this.Level_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Level_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Level_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level_update.Location = new System.Drawing.Point(502, 291);
            this.Level_update.Name = "Level_update";
            this.Level_update.Size = new System.Drawing.Size(127, 86);
            this.Level_update.TabIndex = 4;
            this.Level_update.Text = "Update Level";
            this.Level_update.UseVisualStyleBackColor = false;
            this.Level_update.Click += new System.EventHandler(this.Level_update_Click);
            // 
            // Block_label
            // 
            this.Block_label.AutoSize = true;
            this.Block_label.Location = new System.Drawing.Point(118, 263);
            this.Block_label.Name = "Block_label";
            this.Block_label.Size = new System.Drawing.Size(0, 13);
            this.Block_label.TabIndex = 5;
            // 
            // Speed_label
            // 
            this.Speed_label.AutoSize = true;
            this.Speed_label.Location = new System.Drawing.Point(313, 263);
            this.Speed_label.Name = "Speed_label";
            this.Speed_label.Size = new System.Drawing.Size(0, 13);
            this.Speed_label.TabIndex = 6;
            // 
            // Level_label
            // 
            this.Level_label.AutoSize = true;
            this.Level_label.Location = new System.Drawing.Point(499, 263);
            this.Level_label.Name = "Level_label";
            this.Level_label.Size = new System.Drawing.Size(0, 13);
            this.Level_label.TabIndex = 7;
            // 
            // Money_label
            // 
            this.Money_label.AutoSize = true;
            this.Money_label.Location = new System.Drawing.Point(64, 25);
            this.Money_label.Name = "Money_label";
            this.Money_label.Size = new System.Drawing.Size(0, 13);
            this.Money_label.TabIndex = 8;
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Money_label);
            this.Controls.Add(this.Level_label);
            this.Controls.Add(this.Speed_label);
            this.Controls.Add(this.Block_label);
            this.Controls.Add(this.Level_update);
            this.Controls.Add(this.Speed_Update);
            this.Controls.Add(this.Block_Update);
            this.Controls.Add(this.bu_options);
            this.Controls.Add(this.bu_start);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_start;
        private System.Windows.Forms.Button bu_options;
        private System.Windows.Forms.Button Block_Update;
        private System.Windows.Forms.Button Speed_Update;
        private System.Windows.Forms.Button Level_update;
        private System.Windows.Forms.Label Block_label;
        private System.Windows.Forms.Label Speed_label;
        private System.Windows.Forms.Label Level_label;
        private System.Windows.Forms.Label Money_label;
        private System.Windows.Forms.Timer Tick;
    }
}