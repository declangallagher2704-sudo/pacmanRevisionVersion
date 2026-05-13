using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            SortLeaderboard();
            displayLeaderBoard();
        }
        List<string> User = new List<string>();
        List<string> Password = new List<string>();
        List<int> Score = new List<int>();
        private void SortLeaderboard()
        {
            string[] playerData = File.ReadAllLines("UserdataANDscores.txt");
            bool swapMade = true;
            for (int x = 0; x + 2 < playerData.Length; x += 3)
            {
                User.Add(playerData[x]);
                Password.Add(playerData[x + 1]);
                Score.Add(int.Parse(playerData[x + 2]));
            }
            while (swapMade == true)
            {
                swapMade = false;
                for (int y = 0; y < Score.Count - 1; y++)
                {
                    if (Score[y] < Score[y + 1])
                    {
                        string temp, temp2;
                        int temp3;
                        temp = User[y];
                        temp2 = Password[y];
                        temp3 = Score[y];
                        User[y] = User[y + 1];
                        User[y + 1] = temp;
                        Password[y] = Password[y + 1];
                        Password[y + 1] = temp2;
                        Score[y] = Score[y + 1];
                        Score[y + 1] = temp3;
                        swapMade = true;
                    }
                }
            }
            int fileLines = 0;
            using (StreamReader sizeCheck = new StreamReader("UserdataANDscores.txt"))
            {
                while (sizeCheck.EndOfStream != true)
                {
                    sizeCheck.ReadLine();
                    fileLines += 1;
                }

            }
            using (StreamWriter clearPlayerData = new StreamWriter("UserdataANDscores.txt"))
            {
                for (int v = 0; v > fileLines; v++)
                {
                    clearPlayerData.WriteLine("");
                }
            }
            using (StreamWriter updatedPlayerData = new StreamWriter("UserdataANDscores.txt", true))
            {
                for (int z = 0; z < User.Count; z++)
                {
                    updatedPlayerData.WriteLine(User[z]);
                    updatedPlayerData.WriteLine(Password[z]);
                    updatedPlayerData.WriteLine(Score[z]);
                }
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void displayLeaderBoard()
        {
            number1User.Text = User[0];
            number2User.Text = User[1];
            number3User.Text = User[2];
            number4User.Text = User[3];
            number5User.Text = User[4];
            number1Score.Text = string.Join("",Score[0]);
            number2Score.Text = string.Join("", Score[1]);
            number3Score.Text = string.Join("", Score[2]);
            number4Score.Text = string.Join("", Score[3]);
            number5Score.Text = string.Join("", Score[4]);
        }
    }
}
