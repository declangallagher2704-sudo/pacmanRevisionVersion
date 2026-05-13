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
    public partial class SettingsMenu : Form
    {
        
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (user.usersDetails.player.getMusicPlays())
            {
                mute.Image = Properties.Resources.Unmuted;
            }
            else
            {
                mute.Image = Properties.Resources.mutedIcon;
            }
            volumeBar.Value = user.usersDetails.player.getVolume();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void openControls_Click(object sender, EventArgs e)
        {
            controlsScreen screen = new controlsScreen();
            screen.Show();
            this.Hide();
        }

        private void mute_Click(object sender, EventArgs e)
        {
            if (user.usersDetails.player.getMusicPlays())
            {
                mute.Image = Properties.Resources.mutedIcon;
                user.usersDetails.player.setMusicPlay(false);
            }
            else
            {
                user.usersDetails.player.setMusicPlay(true);
                mute.Image = Properties.Resources.Unmuted;
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            user.usersDetails.player.setVolume(volumeBar.Value);
        }
    }
}
