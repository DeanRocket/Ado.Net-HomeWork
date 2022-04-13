using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3
{
    public partial class H3 : Form
    {
        public H3()
        {
            InitializeComponent();
        }

        private void H3_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet11.Products);
            bindingSource1.DataSource = this.nwDataSet11.Products;
            this.dataGridView1.DataSource = bindingSource1;
            label4.Text = $"{bindingSource1.Position+1}/{bindingSource1.Count}";
            this.bindingNavigator1.BindingSource = bindingSource1;
            lblResult.Text = $"總共有{bindingSource1.Count}筆";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -= 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = bindingSource1.Count-1 ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{bindingSource1.Position+1}/{bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.FillByUnitPrice(nwDataSet11.Products,decimal.Parse(textBox1.Text), decimal.Parse(textBox2.Text));
            bindingSource1.DataSource = nwDataSet11.Products;
;            this.dataGridView1.DataSource = bindingSource1;
            lblResult.Text = $"價格{textBox1.Text}~{textBox2.Text}區間有{bindingSource1.Count}筆";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.FillByProductName(nwDataSet11.Products,textBox3.Text);
            bindingSource1.DataSource = nwDataSet11.Products;
             this.dataGridView1.DataSource = bindingSource1;
            lblResult.Text = $"{textBox3.Text}為{bindingSource1.Count}筆";
        }
    }
}
