using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface ILogWriter
    {
        void Out(string text);
    }
}
