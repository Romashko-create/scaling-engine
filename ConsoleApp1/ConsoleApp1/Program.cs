using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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

