using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Logger
    {
        public ILogWriter logWriter;
        public Logger(ILogWriter logWriter)
        {
            this.logWriter = logWriter;
        }
        public void Write(string text)
        {
            logWriter.Out(text);
        }
    }
}
