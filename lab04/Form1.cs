using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes;

        public Form1()
        {
            InitializeComponent();

            textBoxes = new TextBox[5];
            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
            textBoxes[4] = textBox5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText(); // очищуємо RichTextBox

            // Цикл for у C# має такий ще синтаксис як і С++
            for (int idx = 0; idx < textBoxes.Length; idx++)
            {
                // Оскільки нумерація елементів здійснюється з 0,
                // а за завданням у тексті необхідно нумерувати з 1,
                // обхахуємо номер у деякій змінній, що далі будемо використовувати
                int num = idx + 1;

                // перевіряємо чи TextBox під індексом idx є порожнім
                if (string.IsNullOrEmpty(textBoxes[idx].Text))
                    // додаємо текст у RichTextBox і переходимо на новий рядок (\n)
                    // в якості номеру улементу використовуємо змінну num
                    richTextBox1.AppendText("Елемент " + num + ": Порожньо\n");
                else
                    // додаємо текст з TextBox у RichTextBox і переходимо на новий рядок (\n)
                    // в якості номеру улементу використовуємо змінну num
                    richTextBox1.AppendText("Елемент " + num + ": " + textBoxes[idx].Text + '\n');
            }
        }
    }
}
