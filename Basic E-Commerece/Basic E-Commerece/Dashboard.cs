using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommerceBLL;
using ObjectsCommon;

namespace Basic_E_Commerece
{
    public partial class Dashboard : Form
    {
        public Dashboard(string email)
        {
            InitializeComponent();

            this.label2.Text = email;
            this.dataGridView1.ColumnCount = 5;

            this.dataGridView1.Columns[0].Name = "ID";
            this.dataGridView1.Columns[1].Name = "Name";
            this.dataGridView1.Columns[2].Name = "Category";
            this.dataGridView1.Columns[3].Name = "Price";
            this.dataGridView1.Columns[4].Name = "Quantity";

            UserProd userProd = new UserProd();
            List<Product> products = userProd.getAllProducts();

            foreach (Product product in products)
            {
                string[] temp = { Convert.ToString(product.Id), product.Name, product.category, Convert.ToString(product.price), Convert.ToString(product.quantity) };

                this.dataGridView1.Rows.Add(temp);
            }


            this.dataGridView2.ColumnCount = 4;

            this.dataGridView2.Columns[0].Name = "ID";
            this.dataGridView2.Columns[1].Name = "User Name";
            this.dataGridView2.Columns[2].Name = "Email";
            this.dataGridView2.Columns[3].Name = "Password";

            List<User> users = userProd.getAllUsers();

            foreach (User user in users)
            {
                string[] temp = { Convert.ToString(user.Id), user.Name, user.email, user.password };

                this.dataGridView2.Rows.Add(temp);
            }
        }

        private void Refresh()
        {
            this.dataGridView1.Rows.Clear();

            UserProd userProd = new UserProd();
            List<Product> products = userProd.getAllProducts();

            foreach (Product product in products)
            {
                string[] temp = { Convert.ToString(product.Id), product.Name, product.category, Convert.ToString(product.price), Convert.ToString(product.quantity) };

                this.dataGridView1.Rows.Add(temp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProductForm addproduct = new addProductForm();
            addproduct.ShowDialog();

            Refresh();
        }
    }
}
