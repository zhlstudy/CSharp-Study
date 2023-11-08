using Myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1用接口实现简易计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex < 0) { MessageBox.Show("请选择一种运算方式！！"); return; }
            double n1 = Convert.ToDouble(this.txtNum1.Text);
            double n2 = Convert.ToDouble(this.txtNum2.Text);
            JiSuan cal =new JiSuan();//需要向类中添加数据
            cal.Number1 = n1;
            cal.Number2 = n2;
            string type = cmbType.SelectedItem.ToString();           
            switch (type)
            {
                case "+":          
                    txtResult.Text = Convert.ToString(cal.Jiafa()); break;
                case "-":
                    txtResult.Text = Convert.ToString(cal.Jianfa()); break;
                case "*":
                    txtResult.Text = Convert.ToString(cal.Chengfa()); break;
                case "/":
                    txtResult.Text = Convert.ToString(cal.Chufa()); break;
                default:
                    break;
            }
           
        }
    }
}
