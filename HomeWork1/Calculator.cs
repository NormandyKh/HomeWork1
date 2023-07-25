using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Calculator
    {
        //сложение
        public void Add(double a, double b)
        {
            double result = a + b;
            ShowResult("Сумма чисел", result);
        }

        //вічетание
        public void Subtract(double a, double b)
        {
            double result = a - b;
            ShowResult("Разность чисе", result);
        }

        //умножение
        public void Multiply(double a, double b)
        {
            double result = a * b;
            ShowResult("Произведение чисел", result);
        }

        //деление
        public void Divide(double a, double b)
        {
            if (b != 0)
            {
                double result = a / b;
                ShowResult("Частное чисел", result);
            }
            else
            {
                Console.WriteLine("Деление на ноль недопустимо.");
            }
        }

        //кв. корень 1 числа.
        public void Sqrt(double a)
        {
            if (a >= 0)
            {
                double result = Math.Sqrt(a);
                ShowResult("Квадратный корень числа" , result);
            }
            else
            {
                Console.WriteLine("Невозможно найти квадратный корень отрицательного числа.");
            }
        }

        public void ShowResult(string message, double result)
        {
            Console.WriteLine(message + ": " + result);
        }
    }
}
