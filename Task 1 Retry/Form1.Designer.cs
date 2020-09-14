namespace Task_1_Retry
{
    partial class Form1
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
            this.GameMapUILbl = new System.Windows.Forms.Label();
            this.PlayerStatsLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Upbtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.AttackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameMapUILbl
            // 
            this.GameMapUILbl.AutoSize = true;
            this.GameMapUILbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameMapUILbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMapUILbl.Location = new System.Drawing.Point(196, 131);
            this.GameMapUILbl.Name = "GameMapUILbl";
            this.GameMapUILbl.Size = new System.Drawing.Size(199, 87);
            this.GameMapUILbl.TabIndex = 0;
            this.GameMapUILbl.Text = "XXXXXXXXXXXXX\r\nX...................X\r\nX............H.....X\r\nX..G..........X\r\nX";
            // 
            // PlayerStatsLbl
            // 
            this.PlayerStatsLbl.AutoSize = true;
            this.PlayerStatsLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLbl.Location = new System.Drawing.Point(506, 9);
            this.PlayerStatsLbl.Name = "PlayerStatsLbl";
            this.PlayerStatsLbl.Size = new System.Drawing.Size(125, 68);
            this.PlayerStatsLbl.TabIndex = 1;
            this.PlayerStatsLbl.Text = "Player Stats:\r\nHp:\r\nDamage:\r\n{X,Y]";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(509, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 55);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Upbtn
            // 
            this.Upbtn.Location = new System.Drawing.Point(624, 183);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(61, 50);
            this.Upbtn.TabIndex = 3;
            this.Upbtn.Text = "button1";
            this.Upbtn.UseVisualStyleBackColor = true;
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(624, 239);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(61, 50);
            this.DownBtn.TabIndex = 3;
            this.DownBtn.Text = "button1";
            this.DownBtn.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(557, 213);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(61, 50);
            this.LeftBtn.TabIndex = 3;
            this.LeftBtn.Text = "button1";
            this.LeftBtn.UseVisualStyleBackColor = true;
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(691, 213);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(61, 50);
            this.RightBtn.TabIndex = 3;
            this.RightBtn.Text = "button1";
            this.RightBtn.UseVisualStyleBackColor = true;
            // 
            // AttackBtn
            // 
            this.AttackBtn.Location = new System.Drawing.Point(547, 316);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(205, 47);
            this.AttackBtn.TabIndex = 3;
            this.AttackBtn.Text = "button1";
            this.AttackBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.AttackBtn);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PlayerStatsLbl);
            this.Controls.Add(this.GameMapUILbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameMapUILbl;
        private System.Windows.Forms.Label PlayerStatsLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button AttackBtn;
    }
}

