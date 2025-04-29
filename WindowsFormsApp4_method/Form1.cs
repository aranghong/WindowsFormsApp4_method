using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int num1 = 200;
            //int num2 = 100;

            //int result = Add(num1, num2);
            //textBox1.Text = result.ToString();
            //Nothing();

            int[] result = Div(5, 2);
            textBox1.Text = "값: " + result[0] + "\r\n";
            textBox1.Text += "나머지: " + result[1] + "\r\n";

        }

        //int -> 리턴 값 타입
        //Add -> 함수명
        //int x, int y -> 파라미터 (함수 선언 시 함수가 받아야 하는 입력값(매개변수)들) (함수에 전달되는 외부 데이터)

        //함수 정의=선언 -> 함수 생성
        //함수 호출 -> 함수 사용

        //리턴 -> 함수 내부 코드의 최종 결과 값 (함수 본문에서 최종 결과를 저장 후 돌려줌) (리턴 키워드 만나면 함수 실행 중단)
        int Add(int x, int y)
        {
            return x + y;
        }

        //void -> 반환값이 없을 때 사용하는 키워드

        void Nothing()
        {
            textBox1.Text += "Nothing!";
        }


        int[] Div(int n1, int n2)
        {
            int[] temp = new int[2];
            temp[0] = n1 / n2;
            temp[1] = n1 % n2;
            return temp;
        }
    }
}
