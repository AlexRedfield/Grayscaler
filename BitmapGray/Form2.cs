using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGray
{
    public partial class Form2 : Form
    {
        public static double[] rgb = new double[4];
        
        public double[] _senddata
        {
            get { return rgb; }
        }


        private Form1 f;  //添加私有的父窗体对象

        public Form2(Form1 _f)
        {
            InitializeComponent();       
            f = _f;     //实例化一个父界面用于传值
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //确定键，返回父界面
        private void ReturnColor(object sender, EventArgs e)
        {
            if (customizedBtn.Checked)
            {
                try
                {
                    rgb[0] = double.Parse(textBox1.Text);
                    rgb[1] = double.Parse(textBox2.Text);
                    rgb[2] = double.Parse(textBox3.Text);
                    if (rgb[0] + rgb[1] + rgb[2] <= 3 && rgb[0] + rgb[1] + rgb[2] > 0)
                    {       
                        f._recievedata = this._senddata;    //将参数传回父界面
                        Close();
                    }
                    else
                        MessageBox.Show("请输入使RGB和的值小于等于1的数");
                }
                catch
                {
                    MessageBox.Show("请输入数字");
                }
            }
            else
            {
                f._recievedata = this._senddata;
                Close();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BLabel_Click(object sender, EventArgs e)
        {

        }

        private void maxBtn_CheckedChanged(object sender, EventArgs e)
        {
            String[] message = { "max", "max", "max" };
            changeTextBoxValue(message);
            rgb[3] = 1;  //信号
            textBoxReadonly();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rgb[0] = 0.33; rgb[1] = 0.33; rgb[2] = 0.33;
            changeTextBoxValue(rgb);
            textBoxReadonly();
        }
        private void weightedBtn_CheckedChanged(object sender, EventArgs e)
        {           
            rgb[0] = 0.30; rgb[1] = 0.59; rgb[2] = 0.11;
            changeTextBoxValue(rgb);
            textBoxReadonly();
        }
        private void customizedBtn_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
        }
        public void textBoxReadonly ()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }
        public void changeTextBoxValue(double[] message)
        {
            textBox1.Text = message[0].ToString();
            textBox2.Text = message[1].ToString();
            textBox3.Text = message[2].ToString();
        }
        public void changeTextBoxValue(string[] message)
        {
            textBox1.Text = message[0];
            textBox2.Text = message[1];
            textBox3.Text = message[2];
        }
    }
}
