using System;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;

namespace Test.Core.ViewModels
{
    public class MasterDetailViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;
        public MasterDetailViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            await _navigationService.Navigate<MenuViewModel>();
            await _navigationService.Navigate<ContactUsViewModel>();
        }
    }
}

