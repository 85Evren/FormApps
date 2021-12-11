using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkrem_Click(object sender, EventArgs e) 
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;// sender object olduğu için unboxing yapılmıştır. 
                lboxIsimler.Items.Add(btn.Text);
                lboxIsimler.Items.Add("c## eklenmiştir.");
            }
            else if( sender is TextBox)
            {

                lboxIsimler.Items.Add("c## eklenmiştir.");

            }
        }
    }
}
