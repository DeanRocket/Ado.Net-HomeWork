using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork7.Properties;


namespace HomeWork7
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = UsernameTextBox.Text;
                string PassWord = PasswordTextBox.Text;
                using (SqlConnection conn = new SqlConnection(Settings.Default.NWconnection))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "MyProcedure";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                    command.Parameters.Add("@password", SqlDbType.NVarChar, 40).Value = PassWord;
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("加入資料成功");



                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void OK_Click(object sender, EventArgs e)
        {


        }

    }
}

