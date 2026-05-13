using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace Coursework
{
    

    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }
        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            string username = UserTXT.Text;
            string password = PasswordTXT.Text;
            string alreadyExists = "";
            using (StreamReader existingUser = new StreamReader("UserdataANDscores.txt"))
            {
                while (existingUser.EndOfStream != true && alreadyExists != username)
                {
                    alreadyExists = existingUser.ReadLine();
                }
            }
            if (alreadyExists != username)
            {
                if (username.Length >= 8)
                {
                    if (password.Length > 3)
                    {
                        using (StreamWriter myRegisterWriter = new StreamWriter("UserdataANDscores.txt", true))
                        {
                            myRegisterWriter.WriteLine(username);
                            myRegisterWriter.WriteLine(password);
                            myRegisterWriter.WriteLine(0);
                        }
                        MessageBox.Show("You are now able to login using this username and password");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a password that is at least 3 characters long");
                    }
                }
                else
                {
                    MessageBox.Show("Usernames must be at least 8 characters long");
                }

            }
            else
            {
                MessageBox.Show("This username is already in use");
            }
        }
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username = UserTXT.Text;
            string password = PasswordTXT.Text;
            string userReader = "";
            string passReader = "";
            bool userFound = false;
            using (StreamReader myLoginReader = new StreamReader("UserdataANDscores.txt"))
            {


                while (myLoginReader.EndOfStream != true && userFound == false)
                {
                    userReader = myLoginReader.ReadLine();
                    if (userReader == username)
                    {
                        userFound = true;
                        passReader = myLoginReader.ReadLine();
                        if (passReader != password)
                        {
                            MessageBox.Show("Please enter the correct password for this user");
                        }
                        else
                        {
                            user.usersDetails.player.setuser(username);
                            MainMenu menu = new MainMenu();
                            menu.Show();
                            this.Hide();
                        }
                    }
                    if (myLoginReader.EndOfStream == true)
                    {
                        MessageBox.Show("This username does not exist, please enter another user");
                        UserTXT.Text = "";
                        PasswordTXT.Text = "";
                    }

                }
            }
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
