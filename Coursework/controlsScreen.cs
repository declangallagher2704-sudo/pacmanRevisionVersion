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
    public partial class controlsScreen : Form
    {
        
        public controlsScreen()
        {
            InitializeComponent();
        }
        
        private void controls_Load(object sender, EventArgs e)
        {
        }
        char newkey;
        private void newLeftControl_TextChanged(object sender, EventArgs e)
        {
            if (newLeftControl.Text != "")
            {
                newkey = char.ToUpper(newLeftControl.Text[0]);
                user.usersDetails.player.setLeftKey(newkey);
            }
        }

        private void newRightControl_TextChanged(object sender, EventArgs e)
        {if (newRightControl.Text != "")
            {
                newkey = char.ToUpper(newRightControl.Text[0]);
                user.usersDetails.player.setRightKey(newkey);
            }
        }
        
        private void newUpControl_TextChanged(object sender, EventArgs e)
        {
            if (newUpControl.Text != "")
            {
                newkey = char.ToUpper(newUpControl.Text[0]);
                user.usersDetails.player.setUpKey(newkey);
            }
        }
        
        private void newDownControl_TextChanged(object sender, EventArgs e)
        {
            if (newDownControl.Text != "")
            {
                newkey = char.ToUpper(newDownControl.Text[0]);
                user.usersDetails.player.setDownKey(newkey);
            }
        }

        private void backToSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu settingsScreen = new SettingsMenu();
            settingsScreen.Show();
            this.Hide();
        }
    }
}
