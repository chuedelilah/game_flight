namespace game_flight
{
    partial class See_Charts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rank_bt = new System.Windows.Forms.Button();
            this.score_bt = new System.Windows.Forms.Button();
            this.total_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rank_bt
            // 
            this.rank_bt.Location = new System.Drawing.Point(52, 28);
            this.rank_bt.Name = "rank_bt";
            this.rank_bt.Size = new System.Drawing.Size(85, 40);
            this.rank_bt.TabIndex = 2;
            this.rank_bt.Text = "名稱排序";
            this.rank_bt.UseVisualStyleBackColor = true;
            this.rank_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // score_bt
            // 
            this.score_bt.Location = new System.Drawing.Point(191, 28);
            this.score_bt.Name = "score_bt";
            this.score_bt.Size = new System.Drawing.Size(89, 40);
            this.score_bt.TabIndex = 3;
            this.score_bt.Text = "分數排序";
            this.score_bt.UseVisualStyleBackColor = true;
            this.score_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // total_bt
            // 
            this.total_bt.Location = new System.Drawing.Point(338, 28);
            this.total_bt.Name = "total_bt";
            this.total_bt.Size = new System.Drawing.Size(89, 40);
            this.total_bt.TabIndex = 5;
            this.total_bt.Text = "總成績";
            this.total_bt.UseVisualStyleBackColor = true;
            this.total_bt.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game_flight.Properties.Resources.g3;
            this.pictureBox1.Location = new System.Drawing.Point(462, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 104);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(475, 167);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 40);
            this.back.TabIndex = 6;
            this.back.Text = "回主選單";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // See_Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::game_flight.Properties.Resources.g5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.back);
            this.Controls.Add(this.total_bt);
            this.Controls.Add(this.score_bt);
            this.Controls.Add(this.rank_bt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "See_Charts";
            this.Text = "See_Charts";
            this.Load += new System.EventHandler(this.See_Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rank_bt;
        private System.Windows.Forms.Button score_bt;
        private System.Windows.Forms.Button total_bt;
        private System.Windows.Forms.Button back;
    }
}