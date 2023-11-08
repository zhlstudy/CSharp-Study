using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_MyExplore_我的浏览器
{
    public partial class MyExplortFrm : Form
    {
        public MyExplortFrm()
        {
            InitializeComponent();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtIP.Text.Trim());
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
