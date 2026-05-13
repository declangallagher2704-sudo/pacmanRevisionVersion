using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Drawing.Graphics;
namespace Coursework
{
    class ghost : PictureBox
    {
        gameScreen gameplay;
        Random rand = new Random();
        public string Direction = "left";
        public bool Chase = false;
        public bool inSpawn = true;
        public int Speed, tempspeed;
        public ghost(gameScreen game)
        {
            gameplay = game;
        }
        public void setSpeed(int NSpeed)
        {
            tempspeed = NSpeed;
        }
        public void spawnGhost(Image ghostImage, int spawnX)
        {
            this.Image = ghostImage;
            this.Top = 320;
            this.Left = spawnX;
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Size = new System.Drawing.Size(20, 20);
            this.Tag = "aGhost";
            inSpawn = true;
            gameplay.Controls.Add(this);
        }
        public void MoveGhost(PictureBox pacMan)
        {
            if (inSpawn)
            {
                Speed = rand.Next(1, 3);
                if (this.Left != 312)
                {
                    if (this.Left > 312)
                    {
                        this.Left -= Speed;
                    }
                    else if (this.Left < 312)
                    {
                        this.Left += Speed;
                    }
                    else if ((this.Left == 311) || (this.Left == 313))
                    {
                        this.Left = 312;
                    }
                }
                else
                {
                    if (this.Top > 260)
                    {
                        this.Top -= Speed;
                    }
                    else
                    {
                        inSpawn = false;
                    }
                }
            }
            else
            {
                if (inSpawn)
                {
                    Speed = rand.Next(1, 3);
                    if (this.Left != 312)
                    {
                        if (this.Left > 312)
                        {
                            this.Left -= Speed;
                        }
                        else if (this.Left < 312)
                        {
                            this.Left += Speed;
                        }
                        else if ((this.Left == 311) || (this.Left == 313))
                        {
                            this.Left = 312;
                        }
                    }
                    else
                    {
                        if (this.Top > 260)
                        {
                            this.Top -= Speed;
                        }
                        else
                        {
                            inSpawn = false;
                        }
                    }
                }
                else
                {
                    Speed = tempspeed;

                    int xDist = pacMan.Left - this.Left;
                    int yDist = pacMan.Top - this.Top;

                    bool close = (xDist < 60 && xDist > -60 && yDist < 60 && yDist > -60);

                    if (close)
                    {
                        if (xDist > 0 && xDist > yDist && xDist > -yDist)
                        {
                            this.Left += Speed;
                            Direction = "right";
                        }
                        else if (xDist < 0 && -xDist > yDist && -xDist > -yDist)
                        {
                            this.Left -= Speed;
                            Direction = "left";
                        }
                        else if (yDist > 0)
                        {
                            this.Top += Speed;
                            Direction = "down";
                        }
                        else
                        {
                            this.Top -= Speed;
                            Direction = "up";
                        }
                    }
                    else
                    {
                        if (Direction == "left")
                        {
                            this.Left -= Speed;
                        }
                        else if (Direction == "right")
                        {
                            this.Left += Speed;
                        }
                        else if (Direction == "up")
                        {
                            this.Top -= Speed;
                        }
                        else
                        {
                            this.Top += Speed;
                        }
                    }
                }
            }
        }
        public void HandleWallCollision(Control collision)
        {
            if (this.Bounds.IntersectsWith(collision.Bounds))
            {
                tempspeed = rand.Next(1, 2);
                Chase = false;
                if (Direction == "left")
                {
                    this.Left += tempspeed * 2;
                    Direction = "right";
                }
                else if (Direction == "right")
                {
                    this.Left -= tempspeed * 2;
                    Direction = "left";
                }
                else if (Direction == "up")
                {
                    this.Top += tempspeed * 2;
                    Direction = "down";
                }
                else
                {
                    this.Top -= tempspeed * 2;
                    Direction = "up";
                }
                int newDir = rand.Next(0, 4);
                if (newDir == 0)
                {
                    Direction = "left";
                }
                else if (newDir == 1)
                {
                    Direction = "right";
                }
                else if (newDir == 2)
                {
                    Direction = "up";
                }
                else
                {
                    Direction = "down";
                }
            }
        }
        public void warpGate()
        {
            if (this.Left <= -2)
            {
                this.Left = 645;
            }
            if (this.Left >= 650)
            {
                this.Left = 5;
            }
        }
        public void deleteGhost()
        {
            this.Controls.Remove(this);
        }
    }
}
