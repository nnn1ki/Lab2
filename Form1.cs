using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textA.Text = Properties.Settings.Default.numA.ToString();
            textB.Text = Properties.Settings.Default.numB.ToString();
            textC.Text = Properties.Settings.Default.numC.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //ввод переменных от пользователя
                var numA = int.Parse(this.textA.Text);
                var numB = int.Parse(this.textB.Text);
                var numC = int.Parse(this.textC.Text);

                Logic ans = new Logic(numA, numB, numC);

                this.textAnswer.Text = "Ответ: " + ans.Compare(numA, numB, numC);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }


    public class Logic
    {
        private int a;
        private int b;
        private int c;

        public Logic(int first, int second, int third)
        {
            a = first;
            b = second;
            c = third;            
        }

        //сравнение двух сторон треугольника
        public bool isMore(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            else return false;
        }

        //прямоугольный треугольник или нет
        public bool IsRectangle(int a, int b, int c)
        {
            var mass = new int[] { a, b, c };
            Array.Sort(mass);

            if (Math.Pow(mass[2], 2) >= Math.Pow(mass[1], 2) + Math.Pow(mass[0], 2))
            {
                return true;
            }
            else return false;
        }

        //функция стравнения
        public String Compare(int a, int b, int c)
        {
            String ans = "";

            if (isMore(a + b, c) && isMore(a + c, b) && isMore(b + c, a))
            {
                ans = "Треугольник существует! ";
                if (IsRectangle(a, b, c))
                {
                    ans += "Треугольник прямоугольный!";
                }
                else ans += "Треугольник НЕ прямоугольный!";
            }
            else
            {
                ans = "Треугольника не существует!";
            }

            return ans;
        }

    }

}
