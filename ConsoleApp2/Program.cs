using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine($"bool = {a} ");

            byte b = 255;
            Console.WriteLine($"byte = {b}");

            sbyte c = -128;
            Console.WriteLine($"sbyte = {c}");

            short d = 32767;
            Console.WriteLine($"short = {d}");

            ushort e = 65535;
            Console.WriteLine($"ushort = {e}");

            int f = 214;
            Console.WriteLine($"int = {f}");

            uint g = 4294967295;
            Console.WriteLine($"uint = {g}");

            long h = 34234223;
            Console.WriteLine($"long = {h}");

            ulong i = 0;
            Console.WriteLine($"ulong = {i}");

            float j = 15.5F;
            Console.WriteLine($"float = {j}");

            double k = 3.4;
            Console.WriteLine($"double = {k}");

            decimal l = 3;
            Console.WriteLine($"decimal = {l}");

            char m = 'A';
            Console.WriteLine($"char = {m}");

            string n = "BSTU";
            Console.WriteLine($"string = {n}");

            object o = 3.14;
            Console.WriteLine($"object = {o}");

            Console.WriteLine("Неявные преобразования");

            byte _a = 5;
            short _b = _a;
            Console.WriteLine($"short _b = {_a}");

            byte _c = 8;
            ushort _d = _c;
            Console.WriteLine($"ushort _d = {_c}");

            sbyte _e = -4;
            short _f = _e;
            Console.WriteLine($"short _f = {_e}");

            Console.WriteLine("Явные преобразования");

            int _k = 9;
            byte _l = (byte)(_k);
            Console.WriteLine($"byte _l = {_k}");

            ushort _m = 10;
            int _n = (int)(_m);
            Console.WriteLine($"int _n = {_m}");

            long _o = 12;
            double _p = (double)(_o);
            Console.WriteLine($"double _p = {_o}");

            int __f = Convert.ToInt32("23");
            Console.WriteLine($"__f = {__f}");

            Console.WriteLine("-------Распаковка и упаковка типов-------");

            int stack = 123;
            object heap = stack;
            Console.WriteLine($"object heap = {stack}");

            int stack_1 = 1234;
            object heap_1 = stack_1;
            int stack_2 = (int)heap_1;
            Console.WriteLine($"int stack = { heap_1}");

            Console.WriteLine("Неявно типизированная переменная");

            var number = 3.4;
            Console.WriteLine($"double = {number}");

            Console.WriteLine("Работа с Nullable");

            Nullable<int> f2 = 224;
            Console.WriteLine($"int = {f2}");

            Console.WriteLine("-------Строки-------");

            #region 2a
            string stringA = "string";
            string stringB = "string";

            if (stringA == stringB)
            {

            }
            #endregion

            #region 2b
            string string1 = "string1";
            string string2 = "string2";
            string string3 = "string3";

            string fullstr = string1 + string2 + string3;
            char[] buffer = new char[3];
            string1.CopyTo(0, buffer, 0, 3);

            fullstr.Replace("string", "");
            fullstr.Split("string");
            fullstr.Substring(0, 5);
            fullstr.Insert(0, "insertedString");

            Console.WriteLine($"Result string: {fullstr}");
            #endregion

            #region 2c
            string? nullstring = null;

            if (string.IsNullOrEmpty(nullstring) == true)
            {
                nullstring = "not null string";
            }
            #endregion

            #region 2d
            StringBuilder sbString = new StringBuilder("this is string builder");

            sbString.Remove(3, 1);
            sbString.Append("!");
            sbString.Insert(0, "!");
            #endregion
        

        Console.WriteLine("-------Массив-------");

            int[,] array2 = new int[2, 3];

            for (int iii = 0; iii < 2; iii++)
            {
                for (int jjj = 0; jjj < 3; jjj++)
                {
                    array2[iii, jjj] = iii + jjj;

                    Console.Write(array2[iii, jjj] + " ");
                }
                Console.Write("\n");
            }
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 9 };
            for (int z = 0; z < array1.Length; z++)
            {

                Console.WriteLine(array1[z]);
            }
            Console.WriteLine($"длина массива:{array1.Length}");
            int[] array3 = new int[] { 1, 2, 3, 4, 5, 9, 6 };
            for (int y = 0; y < array3.Length; y++)
            {
                Console.WriteLine(array3[y]);
            }

            Massiv();
            Maini();
            Getfunction();
            made();
        }

        public static void Massiv()
        {
            int i = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[4][];
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            myArr[3] = new int[4];

            // Инициализируем ступенчатый массив
            for (; i < 4; i++)
            {
                myArr[0][i] = i;
                Console.Write("{0}\t", myArr[0][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 6; i++)
            {
                myArr[1][i] = i;
                Console.Write("{0}\t", myArr[1][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                myArr[2][i] = i;
                Console.Write("{0}\t", myArr[2][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[3][i] = i;
                Console.Write("{0}\t", myArr[3][i]);
            }


            Console.WriteLine("\n-------Кортежи-------");

            var tuple = new Tuple<int, string, char, string, ulong>(5, "Hello", 'A', "World", 21);
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);

            (var a, var b) = ("123", 256);
            Console.WriteLine($"{a}, {b}");

            Console.WriteLine("-------Локальная функция-------");


        }

        static void Maini()
        {
            var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine($"сумма элементов массива:{tuple.sum}");
            Console.WriteLine($"минимальное значение элемента:{tuple.min}");
            Console.WriteLine($"максимальное значение элемента:{tuple.max}");

            Console.Read();

            static (int sum, int min, int max) GetNamedValues(int[] numbers)
            {
                var result = (sum: 0, min: 0, max: 0);
                for (int i = 0; i < numbers.Length; i++)
                {

                    result.sum += numbers[i];
                    result.min = numbers[0];
                    result.max = numbers[6];

                }

                return result;
            }



        }

        static void Getfunction()
        {
            int b1 = 2147483647;
            int b2 = 2;



            try
            {

                int sum = unchecked((int)(b1 + b2));

                Console.WriteLine("sum = {0}", sum);

            }
            catch (OverflowException e) { Console.WriteLine(e.Message); }
        }

        static void made()
        {
            #region 2a
            string stringA = "string";
            string stringB = "string";

            if (stringA == stringB)
            {

            }
            #endregion

            #region 2b
            string string1 = "string1";
            string string2 = "string2";
            string string3 = "string3";

            string fullstr = string1 + string2 + string3;
            char[] buffer = new char[3];
            string1.CopyTo(0, buffer, 0, 3);

            fullstr.Replace("string", "");
            fullstr.Split("string");
            fullstr.Substring(0, 5);
            fullstr.Insert(0, "insertedString");

            Console.WriteLine($"Result string: {fullstr}");
            #endregion

            #region 2c
            string? nullstring = null;

            if (string.IsNullOrEmpty(nullstring) == true)
            {
                nullstring = "not null string";
            }
            #endregion

            #region 2d
            StringBuilder sbString = new StringBuilder("this is string builder");

            sbString.Remove(3, 1);
            sbString.Append("!");
            sbString.Insert(0, "!");
            #endregion
        }
    }
    }
