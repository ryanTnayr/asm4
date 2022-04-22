using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm5
{
    public partial class Form1 : Form
    {
        List<string> listPlay = new List<string>();
        int intNeed;
        public Form1()
        {
            InitializeComponent();
            comboxStar.Items.Add("無");
            comboxStar.Items.Add("一星");
            comboxStar.Items.Add("二星");
            comboxStar.Items.Add("三星");
            comboxStar.Items.Add("四星");
            comboxStar.Items.Add("五星");
            comboxStar.Items.Add("六星");
            comboxStar.Items.Add("七星");
            comboxStar.Items.Add("八星");
            comboxStar.Items.Add("九星");
            comboxStar.Items.Add("十星");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                //產生20個隨機碼(1~80) OK
                //避免重複數字 OK
                var rand = new Random();
                List<string> listWin = new List<string>();
                for (int i = 0; i < 20; i++)
                {
                    string mystr = "";
                    while (true)
                    {
                        mystr = rand.Next(1, 81).ToString();
                        if (listWin.IndexOf(mystr) == -1)
                        {
                            break;
                        }
                    }
                    listWin.Add(mystr);
                    Console.WriteLine(listWin[i]);

                }
            //請玩家選擇幾星、倍率(下拉式選單) ok


            //顯示尚需選擇幾個數 ()
            
                //清除目前所有選擇

                //請玩家輸入號碼  OK

                //選擇完數字要讓使用者不能再選  OK

                //{
                //    "1","2","3","4","5","6","7","8","9","10"
                //};

                //空格輸入，需檢查是否有超過範圍
                //按鍵輸入，按下時顏色改變  OK


                //比對數字 OK
                int getCount = 0;

                for (int i = 0; i < listPlay.Count; i++)
                {
                    if (listWin.IndexOf(listPlay[i]) != -1)
                    {
                        getCount++;
                    }

                }
                Console.WriteLine("中了" + getCount);
                //猜大小

                //顯示中獎

                //清除畫面



            }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            pickNum(btn1);
        }
        void pickNum(Button button)
        {
            if (button.BackColor != Color.Gray)  //顏色轉灰不給使用者點
            {
                listPlay.Add(button.Text);
                button.BackColor = Color.Gray;
                intNeed -= 1;
                lblNumLeft.Text = string.Format($"還剩{intNeed}個數字需要選擇");
                foreach (string str in listPlay)
                {
                    Console.WriteLine(str);
                }
            }

        }

        //確定數字
        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblselect1.Show();
        }

        //下拉式選單確定剩餘數目
        private void comboxStar_SelectedIndexChanged(object sender, EventArgs e)
        {
            intNeed = comboxStar.SelectedIndex;
            lblNumLeft.Text = string.Format($"還剩{intNeed}個數字需要選擇");
        }
    }
}
    
    

