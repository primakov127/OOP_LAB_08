using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    interface IManage<T>
    {
        void Add(T item);
        T Remove();
        void Look();
    }
}
