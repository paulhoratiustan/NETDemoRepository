using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Student : Person
    {
        private string _name = null;
        private string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
