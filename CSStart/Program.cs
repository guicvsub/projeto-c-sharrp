using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime UCtd = DateTime.Now;
            double microsecondsinicio = UCtd.Microsecond;
            ForFuntion(0, 100000);
            double millisecondsfim = UCtd.Millisecond;
            double time = millisecondsfim - microsecondsinicio;
            Console.WriteLine($"Tempo de execução do For: {time} ms");
            
            WhileFunction(0, 100000);
            double millisecondsfim2 = UCtd.Millisecond;
            double time2 = millisecondsfim2 - millisecondsfim;
            Console.WriteLine($"Tempo de execução do While: {time2} ms");




        }
        static void ForFuntion(int inicio,int final) {
            for(int i = inicio; i < final; i++)
            {
                Console.WriteLine($"teste",i);
            }

        }
        static void WhileFunction(int inicio, int final) {
            int i = inicio;
            while(i < final)
            {
                Console.WriteLine($"teste",i);
                i++;
            }
        }

    }
}
