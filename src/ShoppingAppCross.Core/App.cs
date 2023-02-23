using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ShoppingAppCross.Core.ViewModels;
using ShoppingAppCross.Core.ViewModels.Home;

namespace ShoppingAppCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart < MasterDetailViewModel>();
        }
    }
}
