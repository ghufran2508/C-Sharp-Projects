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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 6;

            this.dataGridView1.Columns[0].Name = "ID";
            this.dataGridView1.Columns[1].Name = "User Name";
            this.dataGridView1.Columns[2].Name = "Full Name";
            this.dataGridView1.Columns[3].Name = "Email";
            this.dataGridView1.Columns[4].Name = "Password";
            this.dataGridView1.Columns[5].Name = "Date of joining";

            string dir = Path.GetDirectoryName(
                         System.Reflection.Assembly.GetExecutingAssembly().Location);

            string file = dir + @"\Records.txt";

            StreamReader sr = new StreamReader(file);

            string str = sr.ReadLine();

            while(str != null)
            {
                string[] temp = str.Split('|');

                if(temp[temp.Length - 1].Trim() != "Admin")
                    this.dataGridView1.Rows.Add(temp);

                str = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
