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
                InfoText.Text += "Размер массива = " + Cmass.getLengthMass + "\n";
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
            lengthArr.Text = "";
            ElemText.Text = "";
            InputIndex.Text = "";
            InputElemForMulti.Text = "";
            
        }

        private void AddFullMassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int sizeMass = 1;
                foreach (char s in fullMassText.Text)
                {
                    if (s == ':')
                        sizeMass++;
                }
                float[] massBuf = new float[sizeMass];

                string cursor = "";

                sizeMass = 0;

                for (int i = 0; i < fullMassText.Text.Length; i++)
                {
                    if (fullMassText.Text[i] != ':')
                        cursor += fullMassText.Text[i];
                    else
                    {
                        massBuf[sizeMass] = float.Parse(cursor);
                        sizeMass++;
                        cursor = "";
                    }
                }
                massBuf[sizeMass] = float.Parse(cursor);
                Cmass = new CMass(massBuf);
                InfoText.Text += "Массив: ";
                for(int i = 0; i < Cmass.getLengthMass; i++)
                {
                    InfoText.Text += Cmass[i] + ":";
                }
                InfoText.Text += "\n";
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
                int i = 0;
                foreach (char m in InfoText.Text)
                {
                    if (m == ':')
                        i++;
                }
                if (i < Cmass.getLengthMass)
                {
                    Cmass[i] = float.Parse(ElemText.Text);
                    InfoText.Text += ElemText.Text + ":";
                    ElemText.Text = "";
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
            //InfoText.Text += "\n";
            float elem = Cmass[int.Parse(InputIndex.Text)];
            InfoText.Text += "Вы выбрали элемент массива: " + elem + "\n";
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            if (InputElemForMulti.Text != string.Empty)
            {
                InfoText.Text += "\n";
                int MultysizeMass = 1;
                foreach (char s in InputElemForMulti.Text)
                {
                    if (s == ',')
                        MultysizeMass++;

                }
                float[] massBuf = new float[MultysizeMass];

                string cursor = "";

                MultysizeMass = 0;
                int elem = 0;
                for (int i = 0; i < InputElemForMulti.Text.Length; i++)
                {
                    if (InputElemForMulti.Text[i] != ',')
                    {
                        cursor += InputElemForMulti.Text[i];
                        elem += (int)Cmass[int.Parse(cursor)];
                    }

                    else
                    {
                        massBuf[MultysizeMass] = elem;
                        MultysizeMass++;
                        cursor = "";
                        elem = 0;
                    }
                }
                massBuf[MultysizeMass] = elem;
                InfoText.Text += "Произведение = " + Cmass.multiplicationMass(massBuf);
            }
            else
            {
                //если номера не указаны, вычисляется сумма всех элементов
                InfoText.Text += "\n";
                float rezult = 0;
                for (int i = 0; i < Cmass.getLengthMass; i++)
                    rezult += Cmass[i];
                InfoText.Text += "Сумма всех элементов массива = " + rezult;
            }
        }
    }
}
