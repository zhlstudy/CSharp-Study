using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_用抽象实现简易计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex < 0) { MessageBox.Show("请选择一种运算方式！！");return; }
            double num1 = Convert.ToDouble(this.txtNum1.Text);
            double num2 = Convert.ToDouble(this.txtNum2.Text);
            CalculaterDLL cal = null;
            string type = cmbType.SelectedItem.ToString();
            switch (type)
            {
                case "+":
                    cal = new JiaFa(num1, num2);break;
                case "-":
                    cal = new JianFa(num1, num2); break;
                case "*":
                    cal = new ChengFa(num1, num2); break;
                case "/":
                    cal = new ChuFa(num1, num2); break;
                default:
                    break;
            }
            txtResult.Text = cal.JiSuanResult().ToString();
                
        }
    }
}
