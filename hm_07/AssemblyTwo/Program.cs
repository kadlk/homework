using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;


namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Employee.CompanyNamePublic;

            Sum.sumCW(2, 3);
            Console.WriteLine(Sum.sumInt(2, 6));

            Employee Igor = new Employee();
            Igor.Birthdate = 22001999;

            Developer vadim = new Developer();
            Console.WriteLine(vadim.Birthdate);
    }
    }

    

}
