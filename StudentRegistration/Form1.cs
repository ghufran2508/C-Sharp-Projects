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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "" && this.textBox2.Text != "")
            {
                string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

                string file = dir + @"\Records.txt";

                try
                {
                    StreamReader sr = new StreamReader(file);

                    string str = "";
                    str = sr.ReadLine();

                    while (str != null && str != "")
                    {
                        string[] temp = str.Split('|');

                        if (temp[1].Trim() == this.textBox1.Text && temp[3].Trim() == this.textBox2.Text)
                        {
                            sr.Close();

                            if (temp[temp.Length - 1].Trim() == "Admin")
                            {
                                MessageBox.Show("You are Logged IN ADMIN");

                                Form3 adminForm = new Form3();

                                adminForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("You are Logged IN");
                            }
                            return;
                        }

                        str = sr.ReadLine();
                    }

                    sr.Close();

                    MessageBox.Show("INVALID CREDENTIALS");
                }catch (Exception ex)
                {
                    MessageBox.Show("No Account in database");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Details");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Dispose();
            Form2 signupForm = new Form2();

            signupForm.Show();
        }
    }
}
