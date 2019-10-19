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
            this.bu_start = new System.Windows.Forms.Button();
            this.bu_options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bu_start
            // 
            this.bu_start.Location = new System.Drawing.Point(342, 112);
            this.bu_start.Name = "bu_start";
            this.bu_start.Size = new System.Drawing.Size(75, 23);
            this.bu_start.TabIndex = 0;
            this.bu_start.Text = "START";
            this.bu_start.UseVisualStyleBackColor = true;
            this.bu_start.Click += new System.EventHandler(this.Bu_start_Click);
            // 
            // bu_options
            // 
            this.bu_options.Location = new System.Drawing.Point(342, 152);
            this.bu_options.Name = "bu_options";
            this.bu_options.Size = new System.Drawing.Size(75, 23);
            this.bu_options.TabIndex = 1;
            this.bu_options.Text = "OPTIONS";
            this.bu_options.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bu_options);
            this.Controls.Add(this.bu_start);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bu_start;
        private System.Windows.Forms.Button bu_options;
    }
}