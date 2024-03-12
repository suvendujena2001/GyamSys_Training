using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Properties
    {
        public class Person
        {

            //   public string? FirstName { get; set; }

            /*public string? FirstName
            {
                get => _firstName;
            set => _firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
            }
            private string? _firstName;
*/
            public string? FirstName { get; private set; }
        }
    }
}
