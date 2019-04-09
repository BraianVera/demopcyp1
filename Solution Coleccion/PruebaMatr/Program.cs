using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaMatr
{
    class Program
    {

        static int metodo1() { Thread.SpinWait(int.MaxValue); Console.WriteLine("metodo1"); return 22; }
        static int metodo2() { Console.WriteLine("metodo2"); return 11; }
        static void metodo3() { Thread.SpinWait(int.MaxValue); Console.WriteLine("metodo3"); }
        static void metodo4() { Console.WriteLine("metodo4"); }
        static void Main(string[] args)
        {
            //List<Task> tareas = new List<Task>();
            Task<int> t1 = Task<int>.Factory.StartNew(metodo1);
            //tareas.Add(t1);
            Task t2 = t1.ContinueWith((prede) =>
            {
                Console.WriteLine("el resulatado  de metodo1 es:"+prede.Result);

                List<Task> tareas = new List<Task>();
                Task t3 = Task.Factory.StartNew(metodo3);
                tareas.Add(t3);

                Task t4 = Task.Factory.StartNew(metodo4);
                tareas.Add(t4);

                Task.WaitAll(tareas.ToArray());
                //Task.WaitAny();

                metodo2();
            });
            t2.Wait();
            //tareas.Add(t2);


            //Console.WriteLine("tareas posicion " + tareas[1].result(););
            Task.WaitAll();
            Console.WriteLine("Finalizo el programa");
        }
    }
}
