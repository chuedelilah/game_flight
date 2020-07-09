namespace game_flight
{
    partial class Flight_Menu
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
            this.start = new System.Windows.Forms.Button();
            this.Charts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 192);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(88, 41);
            this.start.TabIndex = 1;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Charts
            // 
            this.Charts.Location = new System.Drawing.Point(13, 267);
            this.Charts.Name = "Charts";
            this.Charts.Size = new System.Drawing.Size(87, 41);
            this.Charts.TabIndex = 2;
            this.Charts.Text = "觀看排行榜";
            this.Charts.UseVisualStyleBackColor = true;
            this.Charts.Click += new System.EventHandler(this.Charts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game_flight.Properties.Resources.g1;
            this.pictureBox1.Location = new System.Drawing.Point(190, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 82);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Flight_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::game_flight.Properties.Resources.g2;
            this.ClientSize = new System.Drawing.Size(264, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Charts);
            this.Controls.Add(this.start);
            this.Name = "Flight_Menu";
            this.Text = "Flight_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Charts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}