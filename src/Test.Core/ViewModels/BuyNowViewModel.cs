using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Test.Core.ViewModels
{
    public class BuyNowViewModel : BaseViewModel
    {
        private IMvxNavigationService _navigationService;
        public BuyNowViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}