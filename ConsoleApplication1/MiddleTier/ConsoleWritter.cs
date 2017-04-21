using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MiddleTier
{
    class ConsoleWritter: IMessageWritter
    {
        public void WritePlainMessage(string message)
        {
           //Validate message and send 
           WriteMessageToConsole(message);
        }

        public void WriteFormattedMessage(string message)
        {
            //Validate message and apply any formatting 
            message = "This is your message : " + message;
            WriteMessageToConsole(message);
        }

        private void WriteMessageToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
