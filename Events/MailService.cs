using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Sending Email");
        }
    }
}
