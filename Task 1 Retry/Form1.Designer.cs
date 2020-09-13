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
            this.SuspendLayout();
            // 
            // GameMapUILbl
            // 
            this.GameMapUILbl.AutoSize = true;
            this.GameMapUILbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameMapUILbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMapUILbl.Location = new System.Drawing.Point(226, 145);
            this.GameMapUILbl.Name = "GameMapUILbl";
            this.GameMapUILbl.Size = new System.Drawing.Size(64, 19);
            this.GameMapUILbl.TabIndex = 0;
            this.GameMapUILbl.Text = "label1";
            // 
            // PlayerStatsLbl
            // 
            this.PlayerStatsLbl.AutoSize = true;
            this.PlayerStatsLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLbl.Location = new System.Drawing.Point(569, 25);
            this.PlayerStatsLbl.Name = "PlayerStatsLbl";
            this.PlayerStatsLbl.Size = new System.Drawing.Size(125, 68);
            this.PlayerStatsLbl.TabIndex = 1;
            this.PlayerStatsLbl.Text = "Player Stats:\r\nHp:\r\nDamage:\r\n{X,Y]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerStatsLbl);
            this.Controls.Add(this.GameMapUILbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameMapUILbl;
        private System.Windows.Forms.Label PlayerStatsLbl;
    }
}

