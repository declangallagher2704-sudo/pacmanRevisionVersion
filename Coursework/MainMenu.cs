using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Coursework
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu settingsScreen = new SettingsMenu();
            settingsScreen.Show();
            this.Hide();
        }

        private void openLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard LeaderboardScreen = new Leaderboard();
            LeaderboardScreen.Show();
            this.Hide();
        }

        private void openGame_Click(object sender, EventArgs e)
        {
            gameControl CustomGame = new gameControl();
            CustomGame.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (user.usersDetails.player.getMusicPlays())
            {
                user.usersDetails.player.setMusic("main menu theme.mp3");
            }
        }
    }
}
