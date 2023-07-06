using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Shape
    {
        public abstract int GetResult(int a, int b);
        public virtual int GiveResults(int x)
        {
            return x * 2;
        }
    }
}
