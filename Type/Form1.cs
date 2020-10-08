using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Type
{
    //1-1. 시작하면 텍스트파일 읽어서 리스트에 담기 while문 돌면서 ReadLine으로 한줄씩 읽기
    //1-2. List.Count로 갯수 파악후 난수 발생시키기
    //1-3. 난수에 따른 문장을 라벨에 담기 ex) label4.Text = list[4]
    
    //2-1. 게임시작= 점수0점, 기회 10번 초기화
    //2-2. 남은 기회만큼 반복문 (기회 > 0) {문제 출제}
    //2-3. 문제.text = list[난수]
    //2-4. progressbar.value = 100;
    
    //3-1. 난이도는 단어길이, 속도(인터벌, 맥스밸류)조정 등이 있다.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "200";
            progressBar1.Value = 100;
            //timer1.Interval = 100; 인터벌 조정
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                progressBar1.Value = 0;
                timer1.Stop();
            }
            else
            {
                progressBar1.Value -= 10;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar  == 13)
            {
                timer1.Stop();
                //정답 체크
                if (label4.Text == textBox1.Text)
                {
                    //점수 올림
                }
                else
                {
                    //기회를 빼고 문제를 다시 출제
                }
            }
        }
    }
}
