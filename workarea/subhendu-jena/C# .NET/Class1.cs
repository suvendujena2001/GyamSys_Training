using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Class1
    {
        private string Firstname="Subhendu";
        public string Lastname="Jena";
            public string getFullName()
        {
            return Firstname+Lastname;
        }
        public string getFirstName()
        {
            return Firstname;
        }
        public string getLastName()
        {
            return Lastname;
        }

    }
}
