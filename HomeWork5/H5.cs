using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5
{
    public partial class H5 : Form
    {
        public H5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void H5_Load(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.Fill(awDataSet11.ProductPhoto);
            this.bindingSource1.DataSource = awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = bindingSource1;
            label4.Text = bindingSource1.Position + 1 + "/" + bindingSource1.Count;
            this.bindingNavigator1.BindingSource = bindingSource1;

           

            productPhotoTableAdapter1.FillByDistinct(awDataSet12.ProductPhoto);

           
            for (int i = 0; i < awDataSet12.ProductPhoto.Rows.Count; i++)
            {
                comboBox1.Items.Add(awDataSet12.ProductPhoto[i]["modifieddate"]);
            }
           
        }
        private void button15_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bindingSource1.Position -= 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = bindingSource1.Count - 1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = bindingSource1.Position + 1 + "/" + bindingSource1.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPhotoTableAdapter1.FillByTime(awDataSet11.ProductPhoto,dateTimePicker1.Value,dateTimePicker2.Value);
            this.bindingSource1.DataSource = awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = bindingSource1;
            label4.Text = bindingSource1.Position + 1 + "/" + bindingSource1.Count;
            this.bindingNavigator1.BindingSource = bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.FillByDate(awDataSet11.ProductPhoto);
            this.bindingSource1.DataSource = awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = bindingSource1;
            label4.Text = bindingSource1.Position + 1 + "/" + bindingSource1.Count;
            this.bindingNavigator1.BindingSource = bindingSource1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            productPhotoTableAdapter1.FillByaaaa(awDataSet11.ProductPhoto,Convert.ToDateTime(comboBox1.Text));
          
            this.bindingSource1.DataSource = awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = bindingSource1;
            this.bindingNavigator1.BindingSource = bindingSource1;
        }
    }
}
