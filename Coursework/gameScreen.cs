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

    public partial class gameScreen : Form
    {
        Random rand = new Random();
        bool left, right, up, down, powerActive = false;
        int  playerspeed, seperator, questionAnswer, wrongAnswer;
        int lives = user.usersDetails.player.getlives();
        string lastDirection = "left";
        string subject = user.usersDetails.player.getSubject();
        string difficulty = user.usersDetails.player.getDifficulty();
        string[] fileread = File.ReadAllLines("UserdataANDscores.txt");
        string[] questions;
        string currentQuestion;
        string currentAnswer;
        int userScore, timeInGame,delay, gSpawnDelay, pTimer = 0;
        private Button questionBox;
        private Button answerBox1;
        private Button answerBox2;
        private Button answerBox3;
        ghost inky;
        ghost pinky;
        ghost clyde;
        ghost linky;

        private void answerBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct answer, good job");
            lives += 1;
            gameTimer.Enabled = true;
            pacMan.Left = 303;
            pacMan.Top = 367;
            questionBox.Enabled = false;
            questionBox.Visible = false;
            answerBox1.Enabled = false;
            answerBox1.Visible = false;
            answerBox2.Enabled = false;
            answerBox2.Visible = false;
            answerBox3.Enabled = false;
            answerBox3.Visible = false;
        }


        private void answerBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect, the correct answer was " + currentAnswer);
            gameTimer.Enabled = true;
            pacMan.Left = 303;
            pacMan.Top = 367;
            questionBox.Enabled = false;
            questionBox.Visible = false;
            answerBox1.Enabled = false;
            answerBox1.Visible = false;
            answerBox2.Enabled = false;
            answerBox2.Visible = false;
            answerBox3.Enabled = false;
            answerBox3.Visible = false;
        }
        private void answerBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect, the correct answer was " + currentAnswer);
            gameTimer.Enabled = true;
            pacMan.Left = 303;
            pacMan.Top = 367;
            questionBox.Enabled = false;
            questionBox.Visible = false;
            answerBox1.Enabled = false;
            answerBox1.Visible = false;
            answerBox2.Enabled = false;
            answerBox2.Visible = false;
            answerBox3.Enabled = false;
            answerBox3.Visible = false;
        }



        private void gameScreen_Load(object sender, EventArgs e)
        {
            inky.spawnGhost(Properties.Resources.Inky_up, 270);
            clyde.spawnGhost(Properties.Resources.clyde_up, 295);
            linky.spawnGhost(Properties.Resources.Blinky_up, 330);
            pinky.spawnGhost(Properties.Resources.pinky_up, 355);
            questions = new string[9];
            if (subject == "Math")
            {
                using (StreamReader subQuestions = new StreamReader("Questions.txt"))
                {
                    subQuestions.ReadLine();
                    for (int readIn = 0; readIn < 9; readIn++)
                    {
                        questions[readIn] = subQuestions.ReadLine();
                    }
                }
            }
            else if (subject == "English")
            {
                using (StreamReader subQuestions = new StreamReader("Questions.txt"))
                {
                    for (int skipper = 0; skipper < 11; skipper++)
                    {
                        subQuestions.ReadLine();
                    }
                    for (int EreadIn = 0; EreadIn < 9; EreadIn++)
                    {
                        questions[EreadIn] = subQuestions.ReadLine();
                    }
                }
            }
            else
            {
                using (StreamReader subQuestions = new StreamReader("Questions.txt"))
                {
                    for (int skipper = 0; skipper < 21; skipper++)
                    {
                        subQuestions.ReadLine();
                    }
                    for (int HreadIn = 0; HreadIn < 9; HreadIn++) 
                    {
                        questions[HreadIn] = subQuestions.ReadLine();
                    }
                }
            }
            if (difficulty == "Easy")
            {
                inky.setSpeed(1);
                linky.setSpeed(1);
                pinky.setSpeed(1);
                clyde.setSpeed(1);
                playerspeed = 2;
            }
            else if (difficulty == "Normal")
            {
                inky.setSpeed(2);
                linky.setSpeed(2);
                pinky.setSpeed(2);
                clyde.setSpeed(2);
                playerspeed = 2;
            }
            else
            {
                inky.setSpeed(2);
                linky.setSpeed(2);
                pinky.setSpeed(2);
                clyde.setSpeed(2);
                playerspeed = 1;
            }
            questionBox = new Button();
            questionBox.Location = new Point(222, 146);
            questionBox.Size = new Size(207, 82);
            questionBox.Enabled = false;
            questionBox.Visible = false;
            Controls.Add(questionBox);
            answerBox1 = new Button();
            answerBox1.Location = new Point(113, 399);
            answerBox1.Size = new Size(113, 55);
            answerBox1.Click += answerBox1_Click;
            answerBox1.Enabled = false;
            answerBox1.Visible = false;
            Controls.Add(answerBox1);
            answerBox2 = new Button();
            answerBox2.Location = new Point(263, 399);
            answerBox2.Size = new Size(113, 55);
            answerBox2.Click += answerBox2_Click;
            answerBox2.Enabled = false;
            answerBox2.Visible = false;
            Controls.Add(answerBox2);
            answerBox3 = new Button();
            answerBox3.Location = new Point(417, 399);
            answerBox3.Size = new Size(113, 55);
            answerBox3.Click += answerBox3_Click;
            answerBox3.Enabled = false;
            answerBox3.Visible = false;
            Controls.Add(answerBox3);
            questionBox.BringToFront();
            answerBox1.BringToFront();
            answerBox2.BringToFront();
            answerBox3.BringToFront();
        }
        private void endofGame()
        {
            
            user.usersDetails.player.setScore(userScore.ToString());
            timeInGame = timeInGame / 50;
            user.usersDetails.player.setTime(timeInGame);
            for (int x = 0; x < fileread.Length; x ++)
            {
                if (fileread[x] == user.usersDetails.player.getUsername())
                {
                    if (int.Parse(fileread[x + 2]) < userScore)
                    {
                        fileread[x + 2] = userScore.ToString();
                        using (StreamWriter clearPlayerData = new StreamWriter("UserdataANDscores.txt"))
                        {
                            for (int v = 0; v > fileread.Length; v++)
                            {
                                clearPlayerData.WriteLine("");
                            }
                        }
                        using (StreamWriter updatedPlayerData = new StreamWriter("UserdataANDscores.txt", true))
                        {
                            for (int i = 0; i < fileread.Length; i++)
                            {
                                updatedPlayerData.WriteLine(fileread[i]);
                            }
                        }
                    }
                }
            }
            GameOver endscreen = new GameOver();
            endscreen.Show();
            this.Close();
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (powerActive)
            {
                pTimer += 1;
                if (pTimer > 800)
                {
                    pTimer = 0;
                    powerActive = false;
                }
            }
            gSpawnDelay += 1;
            timeInGame += 1;
            if (userScore == 403)
            {
                endofGame();
            }

            //Allows for movement of pacman and the ghosts
            if (gSpawnDelay > 100)
            {
                inky.MoveGhost(pacMan);
                linky.MoveGhost(pacMan);
                clyde.MoveGhost(pacMan);
                pinky.MoveGhost(pacMan);
            }
            if (left)
            {
                pacMan.Left -= playerspeed;
                if (lastDirection != "left") 
                {
                    pacMan.Image = Properties.Resources.PacMan_Left;
                    lastDirection = "left";
                }
                lastDirection = "left";
            }
            else if (right)
            {
                pacMan.Left += playerspeed;
                if (lastDirection != "right")
                {
                    pacMan.Image = Properties.Resources.PacMan_Right;
                    lastDirection = "right";
                }
                lastDirection = "right";
            }
            else if (up)
            {
                pacMan.Top -= playerspeed;
                if (lastDirection != "up")
                {
                    pacMan.Image = Properties.Resources.PacMan_Up;
                    lastDirection = "up";
                }
                lastDirection = "up";
            }
            else if (down)
            {
                pacMan.Top += playerspeed;
                if (lastDirection != "down")
                {
                    pacMan.Image = Properties.Resources.PacMan_Down;
                    lastDirection = "down";
                }
            }

            //Makes the "warp gates" work
            inky.warpGate();
            linky.warpGate();
            pinky.warpGate();
            clyde.warpGate();
            if (pacMan.Left <= -2)
            {
                pacMan.Left = 645;
            }
            if (pacMan.Left >= 650)
            {
                pacMan.Left = 5;
            }
            //Handles collisions 
            foreach (Control collision in this.Controls)
            {
                if (collision.Tag == "powerPellet")
                {
                    if (pacMan.Bounds.IntersectsWith(collision.Bounds) && collision.Visible == true)
                    {
                        collision.Visible = false;
                        powerActive = true;
                    }
                }               
                if (collision.Tag == "Wall")
                {
                    if (pacMan.Bounds.IntersectsWith(collision.Bounds))
                    {
                        if (left)
                        {
                            left = false;
                            pacMan.Left += playerspeed;
                        }
                        else if (down)
                        {
                            down = false;
                            pacMan.Top -= playerspeed;

                        }
                        if (up)
                        {
                            up = false;
                            pacMan.Top += playerspeed;
                        }
                        if (right)
                        {
                            right = false;
                            pacMan.Left -= playerspeed;
                        }
                    }
                    if (linky.Bounds.IntersectsWith(collision.Bounds))
                    {
                        linky.HandleWallCollision(collision);
                    }
                    if (inky.Bounds.IntersectsWith(collision.Bounds))
                    {
                        inky.HandleWallCollision(collision);
                    }
                    if (pinky.Bounds.IntersectsWith(collision.Bounds))
                    {
                        pinky.HandleWallCollision(collision);
                    }
                    if (clyde.Bounds.IntersectsWith(collision.Bounds))
                    {
                        clyde.HandleWallCollision(collision);
                    }
                }
                if (collision.Tag == "pellet")
                {
                    if (pacMan.Bounds.IntersectsWith(collision.Bounds) && collision.Visible == true)
                    {
                        if (user.usersDetails.player.getMusicPlays() & delay > 5)
                        {
                            user.usersDetails.player.setMusic("pellet pickup.mp3");
                            delay = 0;
                        }
                        else
                        {
                            delay += 1;
                        }
                        string newScore = "";
                        Score.Text = Score.Text.Remove(0, 6);
                        userScore = int.Parse(Score.Text);
                        userScore += 1;
                        newScore = userScore.ToString();
                        Score.Text = ("Score: " + newScore);
                        collision.Visible = false;
                    }
                }
                if (collision.Tag == "pacman")
                {
                    if (collision.Bounds.IntersectsWith(linky.Bounds) || collision.Bounds.IntersectsWith(inky.Bounds) || collision.Bounds.IntersectsWith(pinky.Bounds) || collision.Bounds.IntersectsWith(clyde.Bounds))
                    {
                        if (powerActive)
                        {
                            if (collision.Bounds.IntersectsWith(linky.Bounds))
                            {
                                linky.deleteGhost();
                                linky.spawnGhost(Properties.Resources.Blinky_up, 270);
                                linky.Direction = "left";
                            }
                            if (collision.Bounds.IntersectsWith(inky.Bounds))
                            {
                                inky.deleteGhost();
                                inky.spawnGhost(Properties.Resources.Inky_up, 270);
                                inky.Direction = "left";
                            }
                            if (collision.Bounds.IntersectsWith(pinky.Bounds))
                            {
                                pinky.deleteGhost();
                                pinky.spawnGhost(Properties.Resources.pinky_up, 270);
                                pinky.Direction = "left";
                            }
                            if (collision.Bounds.IntersectsWith(clyde.Bounds))
                            {
                                clyde.deleteGhost();
                                clyde.spawnGhost(Properties.Resources.clyde_up, 270);
                                clyde.Direction = "left";
                            }

                        }
                        else
                        {
                            if (user.usersDetails.player.getMusicPlays())
                            {
                                user.usersDetails.player.setMusic("death sound.mp3");
                            }
                            if (lives == 0)
                            {
                                endofGame();
                            }
                            else
                            {
                                lives -= 1;
                                seperator = rand.Next(0, 9);
                                currentQuestion = questions[seperator].Split(',')[0];
                                questionAnswer = rand.Next(1, 4);
                                wrongAnswer = rand.Next(1, 4);
                                while (wrongAnswer == questionAnswer)
                                {
                                    wrongAnswer = rand.Next(1, 4);
                                }
                                currentAnswer = questions[seperator].Split(',')[1];
                                gameTimer.Enabled = false;
                                Controls.Add(questionBox);
                                Controls.Add(answerBox1);
                                Controls.Add(answerBox2);
                                Controls.Add(answerBox3);
                                if (questionAnswer == 2)
                                {
                                    answerBox1.Left = 263;
                                    if (wrongAnswer == 1)
                                    {
                                        answerBox2.Left = 113;
                                        answerBox3.Left = 417;
                                    }
                                    else
                                    {
                                        answerBox2.Left = 417;
                                        answerBox3.Left = 113;
                                    }
                                }
                                else if (questionAnswer == 3)
                                {
                                    answerBox1.Left = 417;
                                    if (wrongAnswer == 1)
                                    {
                                        answerBox2.Left = 113;
                                        answerBox3.Left = 263;
                                    }
                                    else
                                    {
                                        answerBox2.Left = 263;
                                        answerBox3.Left = 113;
                                    }
                                }
                                questionBox.Enabled = true;
                                answerBox1.Enabled = true;
                                answerBox2.Enabled = true;
                                answerBox3.Enabled = true;
                                questionBox.Text = currentQuestion;
                                answerBox1.Text = currentAnswer;
                                answerBox2.Text = questions[seperator].Split(',')[2];
                                answerBox3.Text = questions[seperator].Split(',')[3];
                                questionBox.Visible = true;
                                answerBox1.Visible = true;
                                answerBox2.Visible = true;
                                answerBox3.Visible = true;
                                questionBox.BringToFront();
                                answerBox1.BringToFront();
                                answerBox2.BringToFront();
                                answerBox3.BringToFront();

                            }
                        }
                    }
                        
                }

            }
        }


        
        public gameScreen()
        {
            InitializeComponent();
            inky = new ghost(this);
            pinky = new ghost(this);
            clyde = new ghost(this);
            linky = new ghost(this);
            this.KeyDown += directionControl;
        }

        //Reads keyboard input and changes directional variables
        private void directionControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys)user.usersDetails.player.getUp())
            {
                up = true;
            }
            if (e.KeyCode == (Keys)user.usersDetails.player.getLeft())
            {
                left = true;
            }
            if (e.KeyCode == (Keys)user.usersDetails.player.getDown())
            {
                down = true;
            }
            if (e.KeyCode == (Keys)user.usersDetails.player.getRight())
            {
                right = true;
            }
            if (e.KeyCode != (Keys)user.usersDetails.player.getUp())
            {
                up = false;
            }
            if (e.KeyCode != (Keys)user.usersDetails.player.getLeft())
            {
                left = false;
            }
            if (e.KeyCode != (Keys)user.usersDetails.player.getDown())
            {
                down = false;
            }
            if (e.KeyCode != (Keys)user.usersDetails.player.getRight())
            {
                right = false;
            }
        }


    }
}