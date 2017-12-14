using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGray
{

    public partial class Form1 : Form
    {
        public static Bitmap origin_bm;
        public static Bitmap converted_bm;

        public static double[] message;

        public Form1()
        {
        
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void upFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图片 | *.jpg; *.png; *.jpeg; *.bmp" ;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string origin_file = fileDialog.FileName;
                //System.Diagnostics.Process.Start(file);   打开文件
                pictureBox1.ImageLocation = origin_file;        //将选择图片置于pictureBox控件内
                origin_bm = new Bitmap(fileDialog.FileName);    //在内存中生成Bitmap图片
            }
            
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("请先创建灰度图像");
            }
            else
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Filter = "BMP文件 (*.bmp) | *.bmp|" + 
                    "JPEG文件 (*.jpg) | *.jpg|" +
                    "PNG文件 (*.png) | *.png";
                // saveDlg.ShowHelp = true;
                saveDlg.OverwritePrompt = true;
                saveDlg.FileName = "新建灰度图片.bmp";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    string saveFile = saveDlg.FileName;
                    string strFil = saveFile.Remove(0, saveFile.Length - 3);
                    //根据填写的文件名将文件保存为不同图像格式
                    switch (strFil)
                    {
                        case "bmp":
                            converted_bm.Save(saveFile, ImageFormat.Bmp);
                            break;
                        case "jpg":
                            converted_bm.Save(saveFile, ImageFormat.Jpeg);
                            break;
                        case "png":
                            converted_bm.Save(saveFile, ImageFormat.Png);
                            break;
                        default:
                            break;
                    }               
                }
            }
            
        }

        public double[] _recievedata
        {
            set {
                message = value;
                if (message[3]!=1)
                    converted_bm=ChangeToGray(origin_bm, message);
                else    //选择的是最大值法
                {
                    converted_bm = ChangeToMaxGray(origin_bm);             
                    message[3] = 0;
                }

                pictureBox2.Image = null;
                pictureBox2.Image = Image.FromHbitmap(converted_bm.GetHbitmap());
                pictureBox2.Refresh();
            }
        }


        private void changeGray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先选择一张图片");
            }
            else
            {
                Form2 f = new Form2(this);
                f.Show();
            }
            
        }

        //根据传入的加权数组rgb来改变图像灰度值
        public static Bitmap ChangeToGray(Bitmap bmp, double[] rgb)
         {
                    for (int i=0;i<bmp.Width;i++)
                    {
                        for (int j=0;j<bmp.Height;j++)
                        {
                            Color color = bmp.GetPixel(i, j);
                            int gray=(int)(color.R* rgb[0] + color.G* rgb[1] + color.B* rgb[2]);
                            Color newColor = Color.FromArgb(gray, gray, gray);
                            bmp.SetPixel(i, j, newColor);
                            
                }
                    }
                    return bmp;
          }

        //最大值算法
        public static Bitmap ChangeToMaxGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int gray = Math.Max(color.R, Math.Max(color.G, color.B));
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                    
                }
            }
            return bmp;
        }        
    }
}
