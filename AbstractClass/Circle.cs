using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Circle : Shape
    {
        public override int GetResult(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override int GiveResults(int x)
        {
            return base.GiveResults(x);
        }
    }
}
