using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMaintenace : Form
    {
        public frmProductMaintenace()
        {
            InitializeComponent();
        }

        private List<Product> products = null;

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                products.Add(product);
            }
            ProductDB.SaveProducts(products);

            FillProductListBox();




        }
        private void FillProductListBox()
        {
            {
                lstProduct.Items.Clear();
                foreach (Product p in products)
                {
                    lstProduct.Items.Add(p.GetDisplayText("    "));
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductMaintenace_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetProducts();
            FillProductListBox();
        }

        private void btnDeletProduct_Click(object sender, EventArgs e)
        {
            int i = lstProduct.SelectedIndex;
            if (i != -1)
            {
                {
                    Product p = products[i];
                    string message = "Are you sure you want to delete " + p.Description + "?";
                    DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (button == DialogResult.Yes)
                    {
                        products.Remove(p);
                        ProductDB.SaveProducts(products);
                        FillProductListBox();
                    }
                }
            }
        }
    }




}
