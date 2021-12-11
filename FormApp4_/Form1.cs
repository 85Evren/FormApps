using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hak;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="admin" && txtPassword.Text== "123") 
            {

                MessageBox.Show("Hoş Geldin Admin.....");

                FrmMain main = new FrmMain();
                main.Show();

            }

            else
            {
                hak++;
                MessageBox.Show($"Hatalı Girişi Yaptınız. Kalan Hakkınız {3- hak}");

                if (hak == 3)
                {
                    MessageBox.Show("Sen Kimsin................?");
                    this.Close();
                }
            }

        }
    }
}
