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
    public partial class HomePage : Form
    {
        public HomePage(string email)
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

        }
    }
}
