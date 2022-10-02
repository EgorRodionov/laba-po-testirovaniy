using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace ClassForm
{
    public partial class Form1 : Form
    {
        CMass Cmass;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void AddSizeArr_Click(object sender, EventArgs e)
        {
            try
            {

                Cmass = new CMass(int.Parse(lengthArr.Text));

                //вывод размера массива на экран
                InfoText.Text += "Размер массива: " + Cmass.getLengthMass + "\n";
            }
            catch
            {
                if(lengthArr.Text == "")
                    MessageBox.Show("Введите размер маcива", "Ошибка", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Неверный формат размера", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InfoText.Text = "";
        }

        private void AddFullMassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int sizeMass = 1;
                foreach (char s in fullMassText.Text)
                {
                    if (s == ',')
                        sizeMass++;
                }
                int[] massBuf = new int[sizeMass];

                Cmass = new CMass(sizeMass);

                    InfoText.Text += "Размер массива: " + Cmass.getLengthMass + "\n";

                    InfoText.Text += "Вывод массива: " + fullMassText.Text + "\n";

                
            }
            catch
            {
                if (fullMassText.Text == "")
                    MessageBox.Show("Введите элементы маcива", "Ошибка", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Неверный формат размера", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void AddElementArr_Click(object sender, EventArgs e)
        {
            try
            {
                string inputstring = ElemText.Text;
                char lastChar = inputstring.Last();
                if (lastChar == ',')
                    MessageBox.Show("Неправильный формат ввода!");

                int sizeMass = 1;
                foreach(char s in ElemText.Text)
                {
                    if (s == ',')
                        sizeMass++;
                }

                if(sizeMass == Cmass.getLengthMass)
                {
                    
                    InfoText.Text += "Вывод массива: " + ElemText.Text + "\n";
                }
                else
                {
                    MessageBox.Show("Введенное количество элементов не совпадает с размером массива!");
                }
            }
            catch
            {
                if (ElemText.Text == "")
                    MessageBox.Show("Введите элементы маcива", "Ошибка", MessageBoxButtons.OK);
                else
                MessageBox.Show("Неверный формат размера", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void SearchIndexBtn_Click(object sender, EventArgs e)
        {
            float a = Cmass[int.Parse(InputIndex.Text)];
            InfoText.Text += "Вы выбрали элемент массива: " + a + "\n";
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
                string inputstring = InputElemForMulti.Text;
            char lastChar = inputstring.Last();
            if (lastChar == ',')
                MessageBox.Show("Неправильный формат ввода!");

            int sizeMass = 1;
            foreach(char s in InputElemForMulti.Text)
            {
                if (s == ',')
                    sizeMass++;

                float[] array = {int.Parse(InputElemForMulti.Text)};
                Cmass.multiplicationMass(array);
                InfoText.Text += "Произведение = " + Cmass.multiplicationMass() + "\n";
            }
        }
    }
}
