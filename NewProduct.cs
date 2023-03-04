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
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }
        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(txtCode.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
            Console.WriteLine(product);
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice);
        }
        private static class Validator
        {
            private static string title = "Entry Error";
            public static string Title
            {

                get
                {
                    return title;
                }
                set
                {
                    title = value;

                }
            }
            public static bool IsPresent(TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                return true;
            }
            public static bool IsDecimal(TextBox textBox)
            {
                try
                {
                    Convert.ToDecimal(textBox.Text);
                    return true;
                }
                catch (FormatException)
                {
                    MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                    textBox.Focus();
                    return false;

                }

            }
        }
    }         
}
