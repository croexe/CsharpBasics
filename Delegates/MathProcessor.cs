using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class MathProcessor
    {
        public int OperationPicker(int a, Func<int,int> pickerHandler)
        {
            return (2*pickerHandler(a));
        }
    }
}
