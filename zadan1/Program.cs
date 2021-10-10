using System;
using System.Collections;
namespace zadan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.Write("n= ");
            int n = 0;
          
                try
                {
                    while (!int.TryParse(Console.ReadLine(), out n))
                    {


                        Console.WriteLine("Ошибка ввода!");

                    }


                    Stack intStak = new Stack();
                    for (int i = 1; i <= n; i++)
                        intStak.Push(i);
                    Console.WriteLine("Размерность " + intStak.Count);
                    Console.WriteLine("Верхний элнмент =  " + intStak.Peek());
                    Console.Write("Содержимое = ");
                    while (intStak.Count != 0)
                        Console.Write("{0} ", intStak.Pop());
                    Console.WriteLine("\n Новая Размерность" + intStak.Count);
                }
                catch
                {
                    Console.WriteLine("Ошибка!!");
                }
         
            //Задание 2


        }
    }
}
