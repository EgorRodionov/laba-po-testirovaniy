using System;

namespace ClassLibrary
{
    public class CMass
    {
        private float[] mass;

        //конструктор с одним параметром –  длина массива
        public CMass(int length)
        {
            mass = new float[length];
        }

        //конструктор с одним параметром – массив вещественных чисел
        public CMass(float []massValue)
        {
            mass = new float[massValue.Length];
            mass = massValue;
        }

        //свойство для определения длины массива
        public float getLengthMass
        {
            get { return mass.Length; }
        }

        //индексатор для доступа к элементам поля-массива
        public float this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }

        //метод с переменным числом параметров для вычисления произведения элементов массива с заданными номерами
        public float multiplicationMass(params float[] arrValues)
        {
            if (arrValues.Length > 0)
            {
                float rezult = 1;
                for (int i = 0; i < arrValues.Length; i++)
                    //вычисляем произведение
                    rezult *= arrValues[i];
                return rezult;
            }
            //если параметров нет, то сложить все эд-мы массива
            else
            {
                float rezult = 0;
                for (int i = 0; i < arrValues.Length; i++)
                    rezult += arrValues[i];
                return rezult;
            }
        }
    }
}
