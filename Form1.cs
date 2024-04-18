using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Fibonacci_method_with_delays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Список для генерации псевдослучайных чисел по методу Фибаначи с запозданием
        List<int> numbersDictionary = new List<int>(56);

        List<int> numbers = new List<int>();

        //Стандартный генератор псевдослучайных чисел
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Заполнение списка через стандартный генератор псевдослучайных чисел
            for (int i = 0; i < 56; i++)
            {
                numbersDictionary.Add(rnd.Next());
            }
        }

        //Реализация генерации псевдослучайных чисел по методу Фибаначи с запозданием
        private int random_Fibonacci(int min, int max, List<int> numDictionary)
        {
            int num;

            //Формула генерации псведослучайного числа
            num  = (Math.Abs(numDictionary.ElementAt(24) + numDictionary.ElementAt(52))) % (max - min + 1) + min;
            
            numDictionary.RemoveAt(0);
            numDictionary.Add(num);
            
            return num;
        }

        private void start_Click(object sender, EventArgs e)
        {
            string numbersSrting = string.Empty;  
            numbers.Clear();

            //Генерайия псевдослучайных чисел
            for (int i = 0; i < numbersCount.Value; i++)
            {
                numbers.Add(random_Fibonacci((int)minValue.Value, (int)maxValue.Value, numbersDictionary));
            }

            foreach (var item in numbers)
            {
                numbersSrting += item + ", ";
            }

            field.Text = numbersSrting;
            

        }
        //Анализ
        private void analysis_Click(object sender, EventArgs e)
        {
            int[] numAnalysis = new int[(int)maxValue.Value + 1];
            for (int i = 0; i <= (int)maxValue.Value; i++)
            {
                numbers.Sort();
                while (numbers.Contains(i))
                {
                    numAnalysis[i]++;
                    numbers.Remove(i);
                }
            }

            chart.Series[0].Points.Clear();
            for (int i = 0; i < numAnalysis.Length; i++)
            {
                chart.Series[0].Points.AddXY(i, numAnalysis[i]);
            }

        }
    }
}
