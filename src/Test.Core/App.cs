using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Test.Core.ViewModels;
using Test.Core.ViewModels.Home;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MasterDetailViewModel>();
        }
    }
}