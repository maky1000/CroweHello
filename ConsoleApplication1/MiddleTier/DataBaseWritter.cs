using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.MiddleTier
{
    class DataBaseWritter : IMessageWritter
    {
        public void WritePlainMessage(string message)
        {

            writeMessageToDatabase(message);
        }

        public void WriteFormattedMessage(string message)
        {
            // apply any format or HttpEncode to the message 
            writeMessageToDatabase(message);
        }

        private void writeMessageToDatabase(string message)
        {
            // connect to Database 
            // Execute DML operation to write message into DB
        }
    }
}
