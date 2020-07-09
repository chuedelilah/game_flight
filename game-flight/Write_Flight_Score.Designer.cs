namespace game_flight
{
    partial class Write_Flight_Score
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
            this.File = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(153, 139);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(69, 42);
            this.File.TabIndex = 0;
            this.File.Text = "存檔";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(101, 71);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 22);
            this.user.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "玩家名稱";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(291, 26);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(33, 12);
            this.score.TabIndex = 4;
            this.score.Text = "label2";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(303, 139);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(74, 42);
            this.back.TabIndex = 6;
            this.back.Text = "回主選單";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(291, 71);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 12);
            this.time.TabIndex = 7;
            this.time.Text = "label2";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(291, 102);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(33, 12);
            this.Grade.TabIndex = 8;
            this.Grade.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 197);
            this.dataGridView1.TabIndex = 9;
            // 
            // Write_Flight_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::game_flight.Properties.Resources.g4;
            this.ClientSize = new System.Drawing.Size(555, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.time);
            this.Controls.Add(this.back);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.File);
            this.Name = "Write_Flight_Score";
            this.Text = "儲存成績囉 ~";
            this.Load += new System.EventHandler(this.Write_Flight_Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button File;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}