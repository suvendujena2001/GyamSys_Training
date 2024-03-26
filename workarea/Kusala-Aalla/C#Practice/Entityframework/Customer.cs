using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Customer
    {
        //Coding by Convention
        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public double Budget { get; set; } = 0;
        public override string ToString()
        {
            return $"{CustomerName} has a budget of {Budget:C}\n";
        }
    }
}
