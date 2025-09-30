using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InputAndOuput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello");
            //Console.Write(" World");
            //Console.WriteLine(", JD");
            //Console.Write("Press Q to exit.");
            //string ret= Console.ReadLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Ret:" + ret);
            //Console.ReadKey();

            string score1 = "95";
            string score2 = "68";



            if ((double.TryParse(score1, out double s_score1 )) && (double.TryParse(score2, out double s_score2)))
            {
            double avgScore = (s_score1 + s_score2) / 2;
            Console.WriteLine(avgScore.ToString("F2"));
            }
            else
            {
                Console.WriteLine("兩個數字都必須是數值");
            }



            //int A = 78;
            //double B = 14.52;
            //B = A;

            //A = (int)B;


            //string dt = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            //Console.WriteLine(dt);
            //DateTime dt1 = Convert.ToDateTime(dt);
            //Console.WriteLine("日期轉換成功");



            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine(j.ToString() + " * " + i.ToString() + "=" + j * i);
            //    }
            //}


            //int[] i = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] j = { 1, 2, 3, 4, 5 };
            //foreach(int _i in i)
            //{
            //    foreach(int _j in j)
            //    {
            //        Console.WriteLine(_j.ToString() + " * " + _i.ToString() + "=" + _j * _i);
            //    }
            //}


            int i = 1;

            while (i <= 9)
            {
                int j = 1;
                while (j <= 5)
                {
                    Console.WriteLine(j.ToString() + " * " + i.ToString() + "=" + j * i);
                    j++;
                }
                i++;
            }




















            Console.ReadKey();



            
        }
    }
}
