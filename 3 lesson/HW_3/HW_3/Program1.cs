/*Сафин Дмитрий
1.
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.*/


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
    struct Complex
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        /*Вычитание комплексных чисел*/
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + x.re * im;

            return y;
        }

        /*        public override string ToString()
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

    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            Complex complex01;
            complex01.re = inputRe;
            complex01.im = inputIm;

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            Complex complex02;
            complex02.re = inputRe02;
            complex02.im = inputIm02;


            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            //Complex complex3 = complex01.Plus(complex02);

            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");

            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");

            Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Multi(complex02)}");

            Console.ReadLine();
        }
    }
}

