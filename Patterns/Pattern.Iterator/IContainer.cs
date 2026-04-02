using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Iterator
{
    public interface IContainer<T>
    {
        IIterator<T> CreateIterator();
    }
}
