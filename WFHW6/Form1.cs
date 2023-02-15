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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                Product tmp = new Product(f2.ProdName, f2.ProdPrice);
                listBox1.Items.Add(tmp);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть продукт зі списку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listBox1.SelectedIndex;
            Product tmp = (Product)listBox1.SelectedItem;
            Form2 f2 = new Form2(tmp);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, f2.prod.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
