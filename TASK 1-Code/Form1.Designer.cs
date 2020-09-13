namespace TASK_1_Code
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
            this.MAPUILbl = new System.Windows.Forms.Label();
            this.PlayerStatsLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MAPUILbl
            // 
            this.MAPUILbl.AutoSize = true;
            this.MAPUILbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAPUILbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPUILbl.Location = new System.Drawing.Point(162, 137);
            this.MAPUILbl.Name = "MAPUILbl";
            this.MAPUILbl.Size = new System.Drawing.Size(82, 70);
            this.MAPUILbl.TabIndex = 0;
            this.MAPUILbl.Text = "XXXXXXX\r\nX.....X\r\nX...G..X\r\n\r\n";
            // 
            // PlayerStatsLbl
            // 
            this.PlayerStatsLbl.AutoSize = true;
            this.PlayerStatsLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLbl.Location = new System.Drawing.Point(453, 22);
            this.PlayerStatsLbl.Name = "PlayerStatsLbl";
            this.PlayerStatsLbl.Size = new System.Drawing.Size(125, 68);
            this.PlayerStatsLbl.TabIndex = 1;
            this.PlayerStatsLbl.Text = "Player Stats:\r\nHP : Hp/HP\r\nDamage: 2\r\nMovement \r\n";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(456, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 114);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(456, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 448);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PlayerStatsLbl);
            this.Controls.Add(this.MAPUILbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MAPUILbl;
        private System.Windows.Forms.Label PlayerStatsLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

