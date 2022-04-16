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
    public partial class addProductForm : Form
    {
        public addProductForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtId.Text != "" && this.txtName.Text != "" && this.txtCategory.Text != "" && this.txtPrice.Text != "" && this.txtQuantity.Text != "")
            {
                Product newProduct = new Product();
                newProduct.Id = Convert.ToInt16(txtId.Text);
                newProduct.Name = txtName.Text;
                newProduct.category = txtCategory.Text;
                newProduct.price = Convert.ToInt16(txtPrice.Text);
                newProduct.quantity= Convert.ToInt16(txtQuantity.Text);

                UserProd adProd = new UserProd();
                bool added = adProd.addNewProduct(newProduct);

                if(added)
                {
                    MessageBox.Show("New Product has beem added");
                }
                else
                {
                    MessageBox.Show("New Product has not beem added");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information.");
            }
        }
    }
}
