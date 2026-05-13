using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void backToMM_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void replay_Click(object sender, EventArgs e)
        {
            gameScreen game = new gameScreen();
            game.Show();
            this.Close();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            int minutes = 00, seconds;
            seconds = user.usersDetails.player.getTime();
           
            while (seconds > 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            timeSpent.Text = minutes.ToString() + ":" + seconds.ToString();
            TotalScore.Text = user.usersDetails.player.getScore();
            if (user.usersDetails.player.getScore() == "403")
            {
                winBox.Visible = true;
            }
            else
            {
                winBox.Visible = false;
            }
        }
    }
}
