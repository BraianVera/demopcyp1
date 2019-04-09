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

        static void metodo1() { Thread.SpinWait(int.MaxValue); Console.WriteLine("metodo1");    }
        static void metodo2() { Console.WriteLine("metodo2"); }
        
        static void Main(string[] args)
        {
            List<Task> tareas = new List<Task>();
            Task t1 = Task.Factory.StartNew(metodo1);
            tareas.Add(t1);
            Task t2 = Task.Factory.StartNew(metodo2);
            tareas.Add(t2);


            Task.WaitAny();
            Console.WriteLine("Finalizo el programa");
        }
    }
}
