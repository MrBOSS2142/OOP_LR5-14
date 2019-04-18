using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    class Error : Exception

    {
        public Error(string massage) : base(massage) { }
        public Error(int number) : base("Error №" + number) { }
    }
}
