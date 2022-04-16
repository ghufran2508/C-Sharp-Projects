using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectsCommon;
using CommerceBLL;

namespace Basic_E_Commerece
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtId.Text != "" && this.txtUsername.Text != "" && this.txtEmail.Text != "" && this.txtPassword.Text != "" && this.txtCPassword.Text != "")
            {
                if(this.txtPassword.Text != this.txtCPassword.Text)
                {
                    MessageBox.Show("Passwords does not match");
                    return;
                }
                else
                {
                    User newUSer = new User();
                    newUSer.Id = this.txtId.Text;
                    newUSer.Name = this.txtUsername.Text;
                    newUSer.email = this.txtEmail.Text;
                    newUSer.password = this.txtPassword.Text;
                    newUSer.is_admin = this.checkBox1.Checked;

                    //now send this object to BLL
                    UserProd useAcc = new UserProd();

                    bool added = useAcc.signUp(newUSer);

                    if(added)
                    {
                        MessageBox.Show("You can now Login to view Dashboard");
                    }
                    else
                    {
                        MessageBox.Show("Email not proper or email already in use");
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the information");
            }
        }
    }
}
