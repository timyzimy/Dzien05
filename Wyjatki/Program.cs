using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 10, j = 0, k;

                try
                {
                    //instrukcje potencjalnie generujace wyjątki
                    k = i / j;
                }
                catch (Exception exc)
                {
                    //Console.WriteLine("Wystąpił wyjątek: {0}", exc.Message);
                }


                // obsluga wielu rodzajow wyjatkow
                try
                {
                    string s1 = Console.ReadLine();
                    int x = Int32.Parse(s1);
                    string s2 = Console.ReadLine();
                    sbyte y = SByte.Parse(s2);
                    Console.WriteLine(x / y);

                    if (y == 1)
                    {
                        throw new Exception("Mój osobisty wyjątek");
                    }

                }
                catch (FormatException exc)
                {
                    Console.WriteLine("Zły format:{0}", exc.Message);
                    throw;
                }
                catch (OverflowException exc)
                {
                    Console.WriteLine("Przepełnienie:{0}", exc.Message);
                }
                catch (ArithmeticException exc)
                {
                    Console.WriteLine("Blad obliczen:{0}", exc.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    Console.WriteLine("Zawsze się wykonam");
                }


                Console.ReadKey();

            } catch (Exception exc)
            {
                Console.WriteLine("Wyjątek");
            }
        }
    }
}
