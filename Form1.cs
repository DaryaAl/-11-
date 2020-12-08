using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Практическая_работа__11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик Алешина Дарья ИСП-31" +
                "Вариант 6" +
                "Практическая работа №11" +
                "Дана строка 'aa aba abba abbba abca abea'." +
                "Напишите регулярное выражение,которое найдет строки aa, aba." +
                "Напишите регулярное выражение, которое найдет строки следующего вида:" +
                " по краям стоят буквы 'a', а между ними - цифра от 3 - х до 7 - ми");
        }

        //Кнопка найти аа aba
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Regex regex1 = new Regex("ab{0,1}a");
            string s = textBox1.Text;
            MatchCollection matches = regex1.Matches(s);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    listBox1.Items.Add(matches[i]);
                }
            }
            else
            {
                MessageBox.Show("Данная строка не найдена");
            }
        }

        //Значения при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "aa aba abba abbba abca abea";
        }

        //Найти строку а(3-7)а
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Regex regex2 = new Regex("a[3-7]a");
            string s1 = textBox1.Text;
            MatchCollection matches2 = regex2.Matches(s1);
            if (matches2.Count > 0)
            {
                for (int i = 0; i < matches2.Count; i++)
                { 
                    listBox2.Items.Add(matches2[i]); 
                }
            }
            else
            {
                MessageBox.Show("Данная строка не найдена");
            }

        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
    
}
