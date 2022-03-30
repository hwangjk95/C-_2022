using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform1_HwangJaeGyu
{
    public partial class frmMain : Form
    {
        //배열의 특징: 고정길이
        string[] names = new string[2];
        string[] numbers = new string[2];
        double[] scores = new double[2];

        int index = 0;

        public frmMain()
        {
            InitializeComponent();
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(index >= numbers.Length) {
                MessageBox.Show("   수강마감");
                return; //megthod를 종료하고, 호출한 쪽으로 제어를 넘긴다.
            }


            //HW1.
            //기존에 해당 학번이 있는지 확인하고, 없으면 진행, 있으면
            // 메세지로 동일 학번 기입력 안내, 종료

            for (int i = 0; i <= index; i++)
            {
                if (tbxNumber.Text == numbers[i])
                {
                    MessageBox.Show("동일학번이 기입력 되었습니다.");
                    return;
                }
            }


            names[index] = tbxName.Text;
            numbers[index] = tbxNumber.Text;
            scores[index] = double.Parse(tbxScore.Text);



            string msg1 = (index + 1) 
                        + "번 학생 정보 : " 
                        +(numbers[index] + "/" 
                        + names[index] + "/" 
                        + scores[index]);
            //문자열 보간법
            string msg2 = $"{index+1}번 학생 정보:" +
                        $"{numbers[index]}/" +
                        $"{names[index]}/" +
                        $"{scores[index]}";

            tbxOutput.Text = msg1;

            index++; //index = index + 1; index +=1;
        }

        private void btnAllview_Click(object sender, EventArgs e)
        {
            /*tbxOutput.Text = "";
            tbxOutput.Text = String.Empty;*/
            tbxOutput.Clear();

            for (int i=0; i< numbers.Length;i++)
            //for (int i=0; i< index;i++)
            {
                if (true == string.IsNullOrEmpty(numbers[i]))
                {
                    continue;  //break;
                }
                tbxOutput.Text += $"{numbers[i]}/{names[i]}/{scores[i]}";
                tbxOutput.Text += Environment.NewLine; //\r
            }
        }

        private void btnAllViewHW1_Click(object sender, EventArgs e)
        {
            //숙제:while문으로 바꾸기 Hw2
            tbxOutput.Clear();
            int i = 0;
            while (i < numbers.Length)
            {
                if (true == string.IsNullOrEmpty(numbers[i]))
                {
                    continue;  //break;
                }
                tbxOutput.Text += $"{numbers[i]}/{names[i]}/{scores[i]}";
                tbxOutput.Text += Environment.NewLine;
                i++;
            }
        }
    }
}
