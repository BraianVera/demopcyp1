using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
       

        public static Dictionary<string, int> values = new Dictionary<string, int>();

        private static string[] nuevo = new string[5];

        static void Main(string[] args)
        {


            

            Console.ReadKey();

        }

       public void ejercicio1()
        {
            String parrafo = Console.ReadLine();

            Console.WriteLine(parrafo);

            string[] separadas;
            separadas = parrafo.Split(' ');

            for (int i = 0; i < separadas.Length; i++)
            {

                if (values.ContainsKey(separadas[i]))
                {

                    int numero = values[separadas[i]];
                    values[separadas[i]] = numero + 1;
                }
                else
                {
                    values.Add(separadas[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> entrada in values)
            {

                Console.WriteLine("{0}, {1}", entrada.Key, entrada.Value);

            }

            Console.ReadKey();
        }


    }
}
