using System;
using System.Threading.Tasks;
using ConsoleApplication1.MiddleTier;
using ConsoleApplication1.ServiceAccessLayer;
using Ninject;

namespace ConsoleApplication1.ApplicationStart
{
    class Program
    {
        static void  Main(string[] args)
        {
            //Initialize Ninject 
            StandardKernel kernel = new StandardKernel();
            kernel.Load(new InjectModules());

            //Requirement : Use configuration files or another industry-standard mechanism for determining where to write the information to.
            // Used named binding (for the sake of simplicity, but this can be configured in a config file or database) Or , we can use Constraints binding 
            // Or simple manual way to replace a concreate class that implements IMessageWritter 
            // based on value from config file or by any other means to accomplish the above requirement 

            IMessageWritter messageWritter = kernel.Get<IMessageWritter>("Console");

            
            WriteMessage(messageWritter).Wait();
            Console.ReadLine();
        }

        public static async Task WriteMessage(IMessageWritter messageWritter)
        {
            CroweServices apIservice = new CroweServices();
            var msg = await apIservice.GetSecretMessage();
            messageWritter.WritePlainMessage(msg);

        }


    }
}
