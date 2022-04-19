using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class H4 : Form
    {
        public H4()
        {
            InitializeComponent();
        }

        private void H4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet11.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet11.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet11.Customers);
            this.dataGridView1.DataSource = nwDataSet11.Categories;
            this.dataGridView2.DataSource = nwDataSet11.Products;
            this.dataGridView3.DataSource = nwDataSet11.Customers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                string s = "";
                string TableName = "";
                TableName = $"{nwDataSet11.Tables[i].TableName,-40}";
                listBox1.Items.Add(TableName);
                listBox1.Items.Add("=====================================================");
                for (int j = 0; j < nwDataSet11.Tables[i].Columns.Count;j++)
                {
                    s += $"{nwDataSet11.Tables[i].Columns[j].ColumnName,-40}  ";
                    
                }
                
                listBox1.Items.Add(s);
                for (int row = 0; row < nwDataSet11.Tables[i].Rows.Count; row++)
                {
                    string data = "";
                    for (int item = 0; item < nwDataSet11.Tables[i].Columns.Count; item++)
                    {
                        data +=$"{(nwDataSet11.Tables[i].Rows[row][item]).ToString(),-40}";
                    }
                    listBox1.Items.Add(data);
                }
            

            }
        }
    }
}
