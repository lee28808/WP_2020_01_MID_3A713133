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
    public partial class Form1 : Form // 主程式大綱
    {
        List<Image> pc = new List<Image>(); //宣告一個陣列pc，陣列裡面放圖片
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //載入的時候
        {
            pc.Add(Resources._1); //陣列裡面放入圖片
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

        private void btn_Click(object sender, EventArgs e) //觸發事件 當按鈕按下的時候
        {
            if (string.IsNullOrWhiteSpace(tex.Text)) //如果輸入是無空白鍵
            {
                MessageBox.Show("請輸入生肖", "錯誤警告"); //會跳出視窗("內容文字","視窗文字")
                return;//終止程式碼
            }
            else //否則
            {
                switch(tex.Text) //索引textbox裡面的內容
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
                    default: //不與上述12種方案相同的則執行此函數
                        MessageBox.Show("請重新輸入生肖", "錯誤警告");
                        break;
                }
                return;
            }
        }
    }
}
