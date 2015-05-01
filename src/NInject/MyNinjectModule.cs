using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using PacketAnalyst.PacketPresenter;
using PacketAnalyst.DataAccess;

namespace PacketAnalyst
{
    public class MyNinjectModule : NinjectModule
    { 
        public override void Load()
        {
            //Bind<IPresenter>().To<ListBoxPresenter>();
            Bind<IPresenter>().To<DataGridViewPresenter>().WithConstructorArgument("pos",new Position(10,100)).WithConstructorArgument("size",new Size(800,280));

            Bind<IPersistence>().To<XMLPersistence>();
            //Bind<IPersistence>().To<SqlServerPersistence>();
        }
    }
}
