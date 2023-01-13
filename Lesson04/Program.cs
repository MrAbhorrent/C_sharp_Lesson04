using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson04
{
    class Program
    {
        private static long LocalPower( int _x, int _pow )
        {
            long result = 1;
            if (_pow != 0)
            {
                for (int i = 1; i <= _pow; i++)
                {
                    result *= _x;
                }
            }
            return result;
        }

        public static float CurrPower( int x, int pow )
        {
            if (x == 0)
            {
                return 0.0f;
            }
            float result = 1.0f;
            if (pow >= 0)
            {
                result = LocalPower(x, pow);
            }
            else
            {
                result = 1.0f / LocalPower(x, Math.Abs(pow));
            }
            return result;
        }

        static void OutputPower( int a, int b )
        {
            Console.WriteLine("Возводим число {0} в натуральную степень {1}. Ответ: {2}", a, b, CurrPower(a, b));
        }

        static private int lengthNumber( int number )
        {
            int lengthNumber = 0;
            if (Math.Abs(number) > 0)
            {
                lengthNumber = Convert.ToInt32(Math.Log10(number) + 1);
            }
            return lengthNumber;
        }

        static private int[] CreateArray( int number, int size )
        {
            int[] array = new int[size];
            while (number > 0)
            {
                array[--size] = number % 10;
                number /= 10;
            }
            return array;
        }

        static private int summArray( int[] _array )
        {
            int summ = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                summ += _array[i];
            }
            return summ;
        }

        static private int SumDigitOfNumber( int _number )
        {
            int size = lengthNumber(_number);
            int[] arrayDigit = new int[size];
            int SumDigitOfNumber = 0;
            arrayDigit = CreateArray(number: _number, size: size);
            SumDigitOfNumber = summArray(arrayDigit);
            return SumDigitOfNumber;
        }

        static private void OutputSummDigitOfNumber( int _number )
        {
            Console.WriteLine("{0} -> {1}", _number, SumDigitOfNumber(_number));
        }


        static void Main( string[] args )
        {
            //  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
            //3, 5 -> 243 (3⁵)
            //2, 4 -> 16
            OutputPower(3, 5);
            OutputPower(2, 4);
            OutputPower(4, 0);
            OutputPower(2, -2);
            OutputPower(0, 1);
            Console.WriteLine("=======================================================================");

            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452 -> 11
            //82 -> 10
            //9012 -> 12
            Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            OutputSummDigitOfNumber(452);
            OutputSummDigitOfNumber(82);
            OutputSummDigitOfNumber(9012);
            Console.WriteLine("=======================================================================");

            //Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
            //1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            //6, 1, 33 -> [6, 1, 33]
            Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.");
            Console.Write("Введите размер массива m = ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array1 = CreateArrayOfSize(sizeArray, true);
            arrayToString(array1);
            Console.WriteLine("=======================================================================");

            Console.ReadKey();
        }

        private static int[] CreateArrayOfSize( int size )
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                //
                Console.WriteLine("Введите {0} элемент массива:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                //                
            }
            return array;
        }

        private static int[] CreateArrayOfSize( int size, bool random )
        {
            int[] array = new int[size];
            if (random) 
            {                
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    //
                    array[i] = rnd.Next(0, 100);
                    //
                }
            }
            return array;
        }

        public static void arrayToString(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write("{0}, ", array[i]);
                }
                else
                {
                    Console.WriteLine("{0}]", array[i]);
                }
            }
        }
    }
}
