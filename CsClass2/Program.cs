using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wanstedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(12345);
            Wanted<double> wantedDouble = new Wanted<double>(12.345);
            Console.WriteLine(wanstedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;
    }
    }
}
