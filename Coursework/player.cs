using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Coursework
{
    class Player
    {
        //Attributes
        private string  username, powerUp, score, subject, difficulty;
        private int time;
        private int liveLeft = 3;
        private int volume = 100;
        private char up = 'W';
        private char down = 'S';
        private char left = 'A';
        private char right = 'D';
        private bool musicPlays = true;
        private WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();

        //Set Methods
        public void stopSound()
        {
            music.controls.stop();
        }
        public void setVolume(int NVolume)
        {
            volume = NVolume;
        }
        public void setMusicPlay(bool NCondition)
        {
            musicPlays = NCondition;
        }
        public void setSubject(string CSubject)
        {
            subject = CSubject;
        }
        public void setDifficulty(string CDifficulty)
        {
            difficulty = CDifficulty;
        }
        public void setuser(string CUser)
        {
            username = CUser;
        }
        public void setPowerUps(string PowerUp)
        {
            powerUp = PowerUp;
        }
       
        public void setScore(string CScore)
        {
            score = CScore;
        }
        public void setTime(int CTime)
        {
            time = CTime;
        }
        public void setlives(int lives)
        {
            liveLeft = lives;
        }
        public void setLeftKey(char NLeft)
        {
            left = NLeft;
        }
        public void setRightKey(char NRight)
        {
            right = NRight;
        }
        public void setUpKey(char NUp)
        {
            up = NUp;
        }
        public void setDownKey(char NDown)
        {
            down = NDown;
        }
        public void setMusic(string CMusic)
        {
            if (music.URL == CMusic)
            {
                music.settings.volume = volume;
                music.controls.stop();
                music.controls.play();
            }
            else
            {
                music.URL = CMusic;
                music.settings.volume = volume;
                music.controls.play();
            }
        }
        //Get Methods
        public int getVolume()
        {
            return volume;
        }
        public string getDifficulty()
        {
            return difficulty;
        }
        public string getSubject()
        {
            return subject;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPowerUps()
        {
            return powerUp;
        }
        public string getScore()
        {
            return score;
        }
        public int getTime()
        {
            return time;
        }
        public int getlives()
        {
            return liveLeft;
        }
        public char getLeft()
        {
            return left;
        }
        public char getRight()
        {
            return right;
        }
        public char getDown()
        {
            return down;
        }
        public char getUp()
        {
            return up;
        }
        public string getCurrentSong()
        {
            return music.URL.ToString();
        }
        public bool getMusicPlays()
        {
            return musicPlays;
        }
    }
}
