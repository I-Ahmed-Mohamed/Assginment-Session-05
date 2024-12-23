using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Session_05
{
    internal class Employee
    {
        public string FristName { get; set; } = null!;
        public string? listName { get; set; } = null;

        public Debaptment Debaptment { get; set; }




    }

    class Debaptment
    {
        public int Code { get; set; }
    }
}
