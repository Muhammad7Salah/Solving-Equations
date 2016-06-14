using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = Console.ReadLine();
            equation = removeSpaces(equation);
            Console.WriteLine(calcuate(equation));
        }

        public static int calcuate(string s)
        {
            string tmp = "";
            // s.ToCharArray();
            if (s.Split('=')[1] == "x" || s.Split('=')[1] == "X")
            {
               // s = s.ToString();
                tmp = s.ToString();
                string h = s.Split('+')[0];
                tmp = s.Split('+')[1].Split('=')[0];

                int a = Convert.ToInt32(h);
                int b = Convert.ToInt32(tmp);

                return a + b;
            }
            else if (s.Split('+')[0] == "x" || s.Split('+')[0] == "X")
            {
               // s = s.ToString();
                tmp = s.ToString();
                string h = s.Split('=')[1];
                tmp = s.Split('+')[1].Split('=')[0];

                int a = Convert.ToInt32(h);
                int b = Convert.ToInt32(tmp);

                return a - b;
            }
            else if (s.Split('+')[1].Split('=')[0] == "x" || s.Split('+')[1].Split('=')[0] == "X")
            {
               // s = s.ToString();
                tmp = s.ToString();
                string h = s.Split('=')[1];
                tmp = s.Split('+')[0];

                int a = Convert.ToInt32(h);
                int b = Convert.ToInt32(tmp);

                return a - b;

            }

            else
                return 0;

        }

        public static string removeSpaces(string s)
        {

            string[] X = new string[s.Split(' ').Length];
            X = s.Split(' ');
            s= "";
            foreach (string a in X)
            {
                s = String.Concat(s, a);
            }
            return s;

        }
    }
}
