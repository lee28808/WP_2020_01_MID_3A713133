using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_MID_3A713133.Properties;

namespace WP_2020_01_MID_3A713133
{
    public partial class Form1 : Form
    {
        List<Image> pc = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pc.Add(Resources._1);
            pc.Add(Resources._2);
            pc.Add(Resources._3);
            pc.Add(Resources._4);
            pc.Add(Resources._5);
            pc.Add(Resources._6);
            pc.Add(Resources._7);
            pc.Add(Resources._8);
            pc.Add(Resources._9);
            pc.Add(Resources._10);
            pc.Add(Resources._11);
            pc.Add(Resources._12);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tex.Text))
            {
                MessageBox.Show("請輸入生肖", "錯誤警告");
                return;//重新檢查
            }
            else
            {
                switch(tex.Text)
                {
                    case "鼠":
                        pic.Image = pc[0];
                        break;
                    case "牛":
                        pic.Image = pc[1];
                        break;
                    case "虎":
                        pic.Image = pc[2];
                        break;
                    case "兔":
                        pic.Image = pc[3];
                        break;
                    case "龍":
                        pic.Image = pc[4];
                        break;
                    case "蛇":
                        pic.Image = pc[5];
                        break;
                    case "馬":
                        pic.Image = pc[6];
                        break;
                    case "羊":
                        pic.Image = pc[7];
                        break;
                    case "猴":
                        pic.Image = pc[8];
                        break;
                    case "雞":
                        pic.Image = pc[9];
                        break;
                    case "狗":
                        pic.Image = pc[10];
                        break;
                    case "豬":
                        pic.Image = pc[11];
                        break;
                    default:
                        MessageBox.Show("請重新輸入生肖", "錯誤警告");
                        break;
                }
                return;
            }
        }
    }
}
