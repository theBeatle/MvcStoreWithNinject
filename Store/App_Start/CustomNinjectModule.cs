using BLL;
using DAL;
using Ninject.Modules;
using System.Data.Entity;

namespace Store
{
    internal class CustomNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMyBll>().To<MyBll>();
            Bind<IMyDal>().To<MyDal>();
            Bind<DbContext>().To<ConcreteMarket>();
        }
    }
}