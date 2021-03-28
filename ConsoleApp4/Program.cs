using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.加法 /n 2.减法/n 3.乘法/n4.除法 ");
            jisuanqi st1 = new jisuanqi();
            
            int z = Convert .ToInt32(Console .ReadLine ());


            //string x = Convert.ToString(Console.ReadLine()), y = Convert.ToString(Console.ReadLine());
            //string input = Console.ReadLine();
            //int o = 0;
            //if (int.TryParse(input, out o))
            //{
            //    Console.WriteLine(o);
            //}
            //else
            //{
            //     Console.WriteLine(input);
            //}


            switch (z)
            {
                case 1:
                    {
                        Console.WriteLine("输入第一个数字");

                        string a = Console.ReadLine();
                        Console.WriteLine("输入第二个数字");

                        string b = Console.ReadLine();
                        double i = 0;
                        double u = 0;
                        double.TryParse(a, out i);
                        
                          if (double.TryParse(b, out u))
                            
                                st1.jiafa(i, u);
                            
                            else
                            
                                st1.jiafa(a, b);

                            
                        
                     
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("输入第一个数字");

                        string a = Console.ReadLine();
                        Console.WriteLine("输入第二个数字");

                        string b = Console.ReadLine();
                        double i = 0;
                        double u = 0;
                        double.TryParse(a, out i);

                        if (double.TryParse(b, out u))

                            st1.jianfa(i, u);

                        else

                            st1.jianfa(a, b);



                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("输入第一个数字");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("输入第2个数字");
                        double b = Convert.ToDouble(Console.ReadLine());
                        st1.chengfa(a, b);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("输入第一个数字");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("输入第2个数字");
                        double b = Convert.ToDouble(Console.ReadLine());
                        st1.chufa(a, b);
                    }
                    break;
            }

            Console.ReadKey();
        }
       
    }
}
