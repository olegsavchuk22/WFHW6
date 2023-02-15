using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW6
{
    public partial class Form2 : Form
    {
        public Product prod = null;
        public string ProdName
        {
            get
            {
                return textBox1.Text;
            }
        }
        public decimal ProdPrice
        {
            get
            {
                return numericUpDown1.Value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Product product)
        {
            InitializeComponent();
            this.textBox1.Text = product.name;
            this.numericUpDown1.Value = product.price;
            this.Text = "Редагувати продукт";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Назва продукту не може бути пустою і ціна не може бути рівною 0", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Product tmp = new Product(textBox1.Text, numericUpDown1.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
