using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { //3.1 средний уровень 10 вариант
           try
           {
                Console.WriteLine("Введите число n:");
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                for (int k = 1; k <= n; k++)
                {
                    if (k == 3 || k == 4) continue;
                    long Fact = 1;
                    for (int i = 1; i <= k + n; i++) Fact *= i;
                    S+= Math.Pow(-1,k) * (k - 7) / Fact;
                }             
                Console.WriteLine($"A={S:F2}");
            }
            catch(Exception ex)
           {
                Console.WriteLine(ex.Message);
           }
        }
    }
}
