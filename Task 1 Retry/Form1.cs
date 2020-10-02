using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_Retry
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameMapUILbl.Text = gameEngine.ToString();
            PlayerStatsLbl.Text = gameEngine.PlayerStatsString();
            InfoTxtbox.Text = gameEngine.EnemyStats();
            
        }

        private void Upbtn_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.Movement.Up);

        }
    }
}
