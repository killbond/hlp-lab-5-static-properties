using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_5_static_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();

            System.Console.Out.WriteLine("{0}, {1}, {2}", t1.GetCount(), t2.GetCount(), t3.GetCount());
            System.Console.Out.WriteLine("{0}, {1}, {2}", t1.GetIndex(), t2.GetIndex(), t3.GetIndex());

            System.Console.In.Read();
        }
    }
}
