using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Cem(int x, int y)
            {
                int cem = x + y;
                Console.WriteLine("İki ededin cemi-" + cem);
            }
            Cem(5, 4);
        }
    }
}
