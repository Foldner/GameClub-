using Ninject.Modules;
using GameClub.Navigation;
using BLL.Interfaces;
using BLL.Services;
using BLL;


namespace GameClub
{
    class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<INavigation>().To<MainNavigation>().InSingletonScope();
            Bind<IdbCrud>().To<dbOperations>();
            Bind<IIncomeCount>().To<IncomeCount>();
        }
    }
}