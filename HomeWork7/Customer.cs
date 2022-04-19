using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HomeWork7.Properties;

namespace HomeWork7
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            this.listView1.View = View.Details;
            CreateListViewColumn();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            try
            {



                using (SqlConnection conn = new SqlConnection(Settings.Default.NWconnection))
                {
                    SqlCommand command = new SqlCommand("select distinct country from customers", conn);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    comboBox1.Items.Add("AllCountry");
                    while (dataReader.Read())
                    {

                        comboBox1.Items.Add(dataReader["country"]);
                    
                    }
                    comboBox1.SelectedIndex = 0;
                   

                }



            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void CreateListViewColumn()
        {
            try {



                using (SqlConnection conn = new SqlConnection(Settings.Default.NWconnection))
                {
                    SqlCommand command = new SqlCommand("select * from customers", conn);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable MyTable = dataReader.GetSchemaTable();

                    for (int i = 0; i < MyTable.Rows.Count; i++)
                    {
                        listView1.Columns.Add(MyTable.Rows[i][0].ToString());
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }



                    }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                listView1.Items.Clear();

                using (SqlConnection conn = new SqlConnection(Settings.Default.NWconnection))
                {
                    SqlCommand command = new SqlCommand();
                    if (comboBox1.Text == "AllCountry")
                    {
                         command.CommandText = "select * from customers ";
                        command.Connection = conn;
                    }
                
                    else
                    {
                        command.CommandText = $"select * from customers where country ='{comboBox1.Text}' ";
                        command.Connection = conn;
                    }
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    Random r = new Random();
                    while (dataReader.Read())
                    {
                      
                       ListViewItem lvi = listView1.Items.Add(dataReader[0].ToString());
                        lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);

                        for (int i = 1; i < dataReader.FieldCount; i++)
                        {  if (dataReader.IsDBNull(i))
                            {
                                lvi.SubItems.Add("空值");
                            }
                            else
                            {
                                lvi.SubItems.Add(dataReader[i].ToString());
                            }
                        }
                        if (lvi.Index % 2 == 0)
                        {
                            lvi.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            lvi.BackColor = Color.Orange;
                        }

                        
                    }
                  

                }



            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
