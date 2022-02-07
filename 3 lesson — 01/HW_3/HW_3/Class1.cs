/*Сафин Дмитрий
1.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    class ComplexClass
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        public double Re
        {
            get
            {
                return re;

            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("На ноль делить нелья!");
                }
                re = value;
            }
        }


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
        /*    if (re == 0)
            {
                throw new Exception("На ноль делить нелья!");
            }*/

            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }

        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        public ComplexClass Multi(ComplexClass x)
        {
            return new ComplexClass(re * x.re - im * x.im, re * x.im + x.re * im);
        }

        /* public override string ToString()
         {
             return $"{re} + {im}i";
         }*/
        public override string ToString()
        {
            if (im > 0)
            {
                return $"{re} + {im}i"; /*. обычная запись комплексного числа*/
            }
            else
            {
                if (im < 0)
                {
                    return $"{re} {im}i";  /*Запись, если мнимая часть отрицательная*/
                }
                else
                {
                    return $"{re}"; /*Запись, если мнимая часть равна 0, только действительная часть*/
                }
            }
        }

    }

    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            ComplexClass complex01 = new ComplexClass(inputRe, inputIm);
            //complex01.Re = 0;

            /*Console.WriteLine(complex01.Re);*/

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            ComplexClass complex02 = new ComplexClass(inputRe02, inputRe02);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");
            

            Console.WriteLine("Укажите действие, которе хотите произвести над числами:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("0 - выход");
            int caseSwitch = int.Parse(Console.ReadLine());

            
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
                    break;
                case 2:
                    Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");
                    break;
                case 3:
                    Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Multi(complex02)}");
                    break;

                case 0:
                    
                    break;

            }

            Console.ReadLine();
        }
    }
}
