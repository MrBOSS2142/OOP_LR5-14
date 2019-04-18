using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    interface INterface<T>
    {
        void Add(T a);
        void Del();
        void Show();
    }
}
