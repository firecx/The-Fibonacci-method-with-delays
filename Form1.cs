using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Fibonacci_method_with_delays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Список (задержка) для генерации псевдослучайных чисел по методу Фибаначи с запозданием
        List<int> numbersDictionary = new List<int>(56);

        //Список содержащий генерируемые числа
        List<int> numbers = new List<int>();

        long a = 1664525;
        long c = 1013904223;
        static long m = 4294967296;
        static long seed = DateTime.Now.Ticks % m;
        long current = seed;

        private void Form1_Load(object sender, EventArgs e)
        {
            int genMax = (int)Math.Pow(2,31);
            //Заполнение списка через стандартный генератор псевдослучайных чисел
            for (int i = 0; i < 56; i++)
            {
                numbersDictionary.Add(Rnd());
            }
            for (int i = 0;i <1000; i++)
            {
                random_Fibonacci(1, genMax, numbersDictionary);
            }
        }

        //Линейный конгруэнтный генератор псевдослучайных чисел
        private int Rnd()
        {   
            current = (a * current + c) % m;
            return (int)current;
        }

        //Реализация генерации псевдослучайных чисел по методу Фибаначи с запозданием
        private int random_Fibonacci(int min, int max, List<int> numDictionary)
        {
            int num;

            //Формула генерации псведослучайного числа
            num = (Math.Abs(numDictionary.ElementAt(24) + numDictionary.ElementAt(52))) % (max - min + 1) + min;
            
            numDictionary.RemoveAt(0);
            numDictionary.Add(num);
            
            return num;
        }


        private void start_Click(object sender, EventArgs e)
        {
            numbers.Clear();

            //Генерайия псевдослучайных чисел
            for (int i = 0; i < numbersCount.Value; i++)
            {
                numbers.Add(random_Fibonacci((int)minValue.Value, (int)maxValue.Value, numbersDictionary));
            }

            List_to_text();
            Analysis();
        }

        //Вывод чисел в TextBox
        private void List_to_text()
        {
            string numbersSrting = string.Empty;
            numbersSrting = String.Join(", ", numbers);
            field.Text = numbersSrting;
        }

        //Анализ распределения сгенерированных чисел
        private void Analysis()
        {
            int[] numAnalysis = new int[(int)maxValue.Value + 1]; // i - число, numAnalysis[i] - количество чисел i
            List<int> list = numbers;
            list.Sort();
            for (int i = 0; i <= (int)maxValue.Value; i++)
            {
                while (list.Contains(i))
                {
                    numAnalysis[i]++;
                    list.Remove(i);
                }
            }

            chart.Series[0].Points.Clear();
            for (int i = 0; i < numAnalysis.Length; i++)
            {
                chart.Series[0].Points.AddXY(i, numAnalysis[i]);
            }
        }


        //Переключение между гистограммой и списком чисел
        private void Switch_Click(object sender, EventArgs e)
        {
            if (chart.Visible == false)
            {
                chart.Visible = true;
                SwitchButton.Text = "Список";
            }
            else
            {
                chart.Visible = false;
                SwitchButton.Text = "Гистограмма";
            }
        }

        //Сохранение сгенерированных чисел
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(field.Text);
                streamWriter.Close();
            }
        }
    }
}
