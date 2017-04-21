using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.MiddleTier;
using Ninject.Modules;

namespace ConsoleApplication1.ApplicationStart
{
    class InjectModules: NinjectModule
    {
        public override void Load()
        {
            Bind<IMessageWritter>().To<ConsoleWritter>().Named("Console");
            Bind<IMessageWritter>().To<DataBaseWritter>().Named("DataBase");
        }
    }
}
