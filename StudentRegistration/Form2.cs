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

namespace StudentRegistration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool alreadyExist(string path, string username)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string str = sr.ReadLine();

                while (str != null)
                {
                    string[] temp = str.Split('|');

                    if (temp[1].Trim() == username)
                    {
                        sr.Close();
                        return true;
                    }

                    str = sr.ReadLine();
                }

                sr.Close();

                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtID.Text != "" && this.txtPassword.Text != "" && this.txtRePassword.Text != "" && this.txtUsername.Text != "")
            {
                if(this.txtPassword.Text != this.txtRePassword.Text)
                {
                    MessageBox.Show("Password dow not match");
                    return;
                }

                string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

                string file = dir + @"\Records.txt";

                if (alreadyExist(file, this.txtUsername.Text) == true)
                {
                    MessageBox.Show("User name Already exist!!!");
                    return;
                }

                StreamWriter sr = new StreamWriter(file, true);

                string str = this.txtID.Text + " | " + this.txtUsername.Text + " | " + this.txtFullName.Text + " | " + this.txtPassword.Text + " | " + this.txtEmail.Text + " | " + this.txtDateJoin.Text;

                if (this.checkBox1.Checked)
                {
                    str += " | " + "Admin";
                }
               
                sr.WriteLine(str);

                sr.Close();

                MessageBox.Show("SignUp complete.");
            } 
            else
            {
                MessageBox.Show("please fill atleast id,fullname,pass,repass");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
