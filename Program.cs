using System;
using BCDLib;
using System.IO;
using System.Collections.Generic;

namespace BCDComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //BCD a = BCD.Parse("9980");
            //BCD b = BCD.Parse("-1");
            //BCD c = BCD.Parse("31");

            //BCD ans = a / c;

            //Console.WriteLine($"anw={ans}  rem ={ans.Rem}");


            //List<BCD> num = new List<BCD>();
            //num.Add(BCD.Parse("2"));

            //for (BCD i = BCD.Parse("2"); BCD.Parse("100") > i; i+=1)
            //{
            //    BCD an = BCD.Zero;

            //    foreach (BCD n in num)
            //    {
            //        BCD ab = i / n;
            //        if (!BCD.IsZero(ab.Rem))
            //            an = i;
            //    }
            //    if (!BCD.IsZero(an))
            //        Console.WriteLine(an);
            //}


            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine(a -b + c);

            //for(int i=-5; 15>=i; i++)
            //    for(int j=-3; 15>=j;j++)
            //    {
            //        //Console.WriteLine($"{j} * {i} = {BCD.Parse(j.ToString()) * BCD.Parse(i.ToString())}");
            //    }
            StreamWriter sw = null;
            try
            {


                sw = new StreamWriter(@"D:\workspace\factorial-A1.txt");
            BCD ans = BCD.Parse("1");
            long f = 1000000000000;
            for (long i = 1; f >= i; i++)
            {
                if (i % 10000 == 0)
                {
                    sw.Flush();
                    sw.Close();
                    sw = new StreamWriter($@"D:\workspace\factorial-A{i}.txt");
                    Console.Write('■');
                }
                ans = ans * BCD.Parse(i.ToString());
                sw.WriteLine($"{i}! = {ans}");
                sw.Flush();
            }
        }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("stop.");
            }
            finally
            {
                sw.Flush();
                sw.Close();
                Console.ReadLine();
            }


            //BCD az = BCD.Parse("0");
            //int len = 1000000;
            //long jj = 0;
            //for (int i = 0; len > i; i++)
            //{
            //    if (i % (len/10) == 0)
            //        Console.Write('■');
            //    az = az + BCD.Parse(i.ToString());

            //}
            //    Console.WriteLine(az);
        }
    }
}
