<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Constructors
    {
        public class Person
        {
            private string last;
            private string first;

            public Person(string lastName, string firstName)
            {
                last = lastName;
                first = firstName;
            }

            // Remaining implementation of Person class.
        }

        public class Location
        {
            private string locationName;

            public Location(string name) => Name = name;

            public string Name
            {
                get => locationName;
                set => locationName = value;
            }
        }

        public class Adult : Person
        {
            private static int minimumAge;

            public Adult(string lastName, string firstName) : base(lastName, firstName)
            { }

            static Adult()
            {
                minimumAge = 18;
            }

            // Remaining implementation of Adult class.
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Constructors
    {
        public class Person
        {
            private string last;
            private string first;

            public Person(string lastName, string firstName)
            {
                last = lastName;
                first = firstName;
            }

            // Remaining implementation of Person class.
        }

        public class Location
        {
            private string locationName;

            public Location(string name) => Name = name;

            public string Name
            {
                get => locationName;
                set => locationName = value;
            }
        }

        public class Adult : Person
        {
            private static int minimumAge;

            public Adult(string lastName, string firstName) : base(lastName, firstName)
            { }

            static Adult()
            {
                minimumAge = 18;
            }

            // Remaining implementation of Adult class.
        }
    }
}
>>>>>>> origin/main
