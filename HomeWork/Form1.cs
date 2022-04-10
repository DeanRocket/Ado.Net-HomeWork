using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            if (num % 2 == 0) {

                labResult.Text = "你所輸入的數字" + num + "為偶數";
            }
            else
                labResult.Text = "你所輸入的數字" + num + "為奇數";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] MaxArray = { 100, 77, 66 };
            int MaxValue = MaxArray[0];
            foreach (int item in MaxArray)
            {
                if (MaxValue < item)
                    MaxValue = item;
            
            }
            labResult.Text = "最大值為" + MaxValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            for (int i = 1; i <= 9; i++) {

                for (int j = 1; j <= 9; j++)
                {

                    if (j == 9) {

                        labResult.Text += i + "*" + j + "=" + i * j + "\n";
                    }
                    else
                    labResult.Text += i + "*" + j + "=" + i * j+"  ";
                
                }
            
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int a = 100;
            List<int> MyList = new List<int>();
            while (a > 1)
            {
                MyList.Add(a%2);
                a /= 2;
            }
            if (a == 1)
            {
                MyList.Add(a);
            }


            int[] MyArray = MyList.ToArray();
            for (int i = MyArray.Length-1; i >= 0; i--)
            {
                labResult.Text += MyArray[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int odd = 0;
            int even = 0;
            foreach (int item in nums)
            {
                if (item % 2 == 0)
                {

                    even += 1;
                }
                else {

                    odd += 1;
                }
            
            }
            labResult.Text = "奇數有" + odd + "個\n" + "偶數有" + even + "個";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk" };
            int MaxNames = names[0].Length;
            string Name = "";
            foreach (string item in names)
            {
                if (MaxNames < item.Length)
                    MaxNames = item.Length;
                Name = item;
            
            }
            labResult.Text = "最長名字為" + Name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            string[] names = { "aaa", "ksdkfCjsdk","cake","carrot" };
            foreach (string item in names) {

                if (item.Contains('c') || item.Contains ('C'))
                {
                    labResult.Text += item +" ";
                }
            
            
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyMaxValues(98, 78, 60, 50, 40, 30, 99);
        }
        void MyMaxValues(params int[] score) {

            int MaxValue = score[0];
            foreach (int item in score)
            {
                if (item > MaxValue)
                {
                    MaxValue = item;
                }
            }
            labResult.Text = "最大值為" + MaxValue;
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            int max = scores.Max();
            int min = scores.Min();
            labResult.Text = "最大值為:" + max + "\n最小值為:" + min;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            Random RndNum = new Random();
            for (int i = 0; i <= 5; i++)
            {

               labResult.Text+= RndNum.Next(1, 50)+" ";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        { int num=0;
          
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            int x = int.Parse(textBox3.Text);
            int count = 0;
            for (num = i; num <= j; num += x)
            {
                count += num;
            }
            labResult.Text = count.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            int x = int.Parse(textBox3.Text);
            int count = 0;
            
            while(i<=j)
            {
                count += i;
                i += x;
                
            }
            labResult.Text = count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            int x = int.Parse(textBox3.Text);
            int count = 0;
            do {
                count += i;
                i += x;
            }
            while (i<=j);
            labResult.Text = count.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
        }
    }
}
