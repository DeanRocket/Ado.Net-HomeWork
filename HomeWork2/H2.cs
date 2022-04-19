using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class H2 : Form
    {
        public H2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.FillByCategory(nwDataSet1.Products,comboBox1.Text);

            
            bindingSource2.DataSource = nwDataSet1.Products;
             
            this.dataGridView1.DataSource = bindingSource2;
           
            //comboBox1.DataBindings.Add("text", bindingSource1, "categoryname");
        }

        private void H2_Load(object sender, EventArgs e)
        {
            categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            bindingSource1.DataSource = nwDataSet1.Categories;

            //combobox 連接
            int i = 0;
            while(i <nwDataSet1.Categories[0].Table.Rows.Count)
            {
                comboBox1.Items.Add(nwDataSet1.Categories.Rows[i]["categoryname"].ToString());
                i++;
            }
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
