using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(6, 6);

            Console.WriteLine(result.ToString());
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public int AddNumbers(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}
