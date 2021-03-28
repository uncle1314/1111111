
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class jisuanqi
    {
        double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }

        string a, b;
        public void jiafa(double a,double b)
        {
            Console.WriteLine(a+b); 
        }
        public void jianfa(double a, double b)
        {
            Console.WriteLine(a-b);
        }
        public void chengfa(double a, double b)
        {
            Console.WriteLine(a*b);
        }
        public void chufa(double a, double b)
        {
            Console.WriteLine(a/b);
        }
        public void jiafa(string a, string b)
        {
            Console.WriteLine(a+b);
        }
        public void jianfa(string a, string b)
        {
            a = Console.ReadLine();
            b = Console.ReadLine();
            //Regex r = new Regex(b);
            //a = r.Replace(a, b);
            //Console.WriteLine(a);
            string StringRepace()
            {

                Regex r = new Regex(b);
                a = r.Replace(a, "");
                return a;
            }

            Console.WriteLine(StringRepace());
        }

    }
}
