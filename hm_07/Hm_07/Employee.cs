using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        // can not access from another class in the same project
        const string CompanyName = "Home";
        private const string CompanyNamePrivate = "Home";
        protected const string CompanyNameProtected = "Home";

        // this way we can acces from the same project
        // with the help of "PUBLIC" we can acces from another project 
        public const string CompanyNamePublic = "Home";
        internal const string CompanyNameInternal = "Home";
        protected internal const string CompanyNameProtectedInternal = "Home";

        // is not available in C# 7.0
        // private protected const string CompanyNamePrivateProtected = "Home";

        public string Gender;
        public int Birthdate;
    }

    
}
