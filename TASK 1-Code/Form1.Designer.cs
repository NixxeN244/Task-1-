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
            this.SuspendLayout();
            // 
            // MAPUILbl
            // 
            this.MAPUILbl.AutoSize = true;
            this.MAPUILbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAPUILbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPUILbl.Location = new System.Drawing.Point(277, 236);
            this.MAPUILbl.Name = "MAPUILbl";
            this.MAPUILbl.Size = new System.Drawing.Size(82, 70);
            this.MAPUILbl.TabIndex = 0;
            this.MAPUILbl.Text = "XXXXXXX\r\nX.....X\r\nX...G..X\r\n\r\n";
            // 
            // PlayerStatsLbl
            // 
            this.PlayerStatsLbl.AutoSize = true;
            this.PlayerStatsLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLbl.Location = new System.Drawing.Point(578, 42);
            this.PlayerStatsLbl.Name = "PlayerStatsLbl";
            this.PlayerStatsLbl.Size = new System.Drawing.Size(125, 68);
            this.PlayerStatsLbl.TabIndex = 1;
            this.PlayerStatsLbl.Text = "Player Stats:\r\nHP : Hp/HP\r\nDamage: 2\r\nMovement \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
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
    }
}

