using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommerceBLL;
using ObjectsCommon;

namespace Basic_E_Commerece
{
    public partial class Form1 : Form
    {
        string email;
        //string pass;
        //string id;
        //string name;
        //bool admin;

        public Form1()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(path);
        }
        ~Form1()
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserProd userAccount = new UserProd();

            User c_user = userAccount.getUser(this.txtEmail.Text,this.txtPassword.Text);

            if(c_user != null)
            {
                email = c_user.email;

                if (c_user.is_admin)
                {
                    Dashboard db = new Dashboard(email);
                    db.Show();

                    
                }
                else
                {
                    HomePage hp = new HomePage(email);
                    hp.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }
       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
