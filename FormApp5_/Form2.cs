using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp5_
{
    public partial class Form2 : Form
    {

       public Form1 mainForm;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            mainForm.lBoxOgrenciler.Items.Add(textBoxOgrenci.Text);
            //this.Hide();
            //mainForm.Show();


        }
    }
}
