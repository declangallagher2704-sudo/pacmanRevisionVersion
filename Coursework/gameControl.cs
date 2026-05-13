using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class gameControl : Form
    {
        bool difficultyPressed,subjectPressed = false;
        public gameControl()
        {
            InitializeComponent();
        }

        private void gameControl_Load(object sender, EventArgs e)
        {
            string[] fileread = File.ReadAllLines("Questions.txt");
            englishBTN.Text = fileread[0];
            historyBTN.Text = fileread[10];
            mathBTN.Text = fileread[20];
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
        private void englishBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setSubject("English");
            difficultyPressed = true;
        }

        private void historyBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setSubject("History");
            difficultyPressed = true;
        }

        private void mathBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setSubject("Math");
            difficultyPressed = true;
        }

        private void easyBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setDifficulty("Easy");
            subjectPressed = true;
        }

        private void normalBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setDifficulty("Normal");
            subjectPressed = true;
        }

        private void hardBTN_Click(object sender, EventArgs e)
        {
            user.usersDetails.player.setDifficulty("Hard");
            subjectPressed = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (difficultyPressed && subjectPressed)
            {
                gameScreen CustomGame = new gameScreen();
                CustomGame.Show();
                this.Hide();
            }
            else if (difficultyPressed && !(subjectPressed))
            {
                MessageBox.Show("Please enter a subject");
            }
            else if (subjectPressed && !(difficultyPressed))
            {
                MessageBox.Show("Please enter a difficulty");
            }
            else
            {
                MessageBox.Show("Please select the options available");
            }
        }
    }
}
