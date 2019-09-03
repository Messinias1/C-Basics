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
            worker.Count(4);
            worker.Count(5);
            worker.Count(4.5f);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public void Count (int number)
        {
            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }

        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }
        public float Total { get; set; }
    }
}
