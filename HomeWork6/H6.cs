using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class H6 : Form
    {
        public H6()
        {
            InitializeComponent();
        }

        private void H6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                LinkLabel myCity = new LinkLabel();
                myCity.Tag = i;
                myCity.Text = "Taipei" + myCity.Tag;
               myCity.Top = 80*i;
                panel1.Controls.Add(myCity);
                myCity.Click += MyCity_Click;
                

            
            }
            
        }

        private void MyCity_Click(object sender, EventArgs e)
        {
            LinkLabel City = sender as LinkLabel;
          
            MessageBox.Show(City.Text);

        }
    }
}
