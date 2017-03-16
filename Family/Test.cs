using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Test
    {
        static void Main(string[] args)
        {
            Mother mother = new Mother();
            Daughters daughter = new Daughters();
            mother.display();
            daughter.display();
            Console.ReadLine();
        }
    }
}
