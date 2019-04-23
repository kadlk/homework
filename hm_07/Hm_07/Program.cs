using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssemblyOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            string CompanyName = Employee.CompanyNameInternal;
            string CompanyName1 = Employee.CompanyNamePublic;
            string CompanyName2 = Employee.CompanyNameProtectedInternal;

            Developer vadim = new Developer();
            vadim.Gender = "male";
            vadim.Birthdate = 30041989;
            vadim.Postition = "junior";
            vadim.Technology = "C#";

            Console.WriteLine($"Gender: {vadim.Gender} \nBirthdate: {vadim.Birthdate} \nTechnology: {vadim.Technology} \nPostition: {vadim.Postition}");
            Console.WriteLine("\nTrying to call method");
            Sum.sumCW(2, 3);
            Console.WriteLine(Sum.sumInt(2, 6));
            Console.Read();
        }
    }
}
