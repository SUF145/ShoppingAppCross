using System;
using System.Collections.ObjectModel;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ShoppingAppCross.Core.ViewModels
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
            await _navigationService.Navigate<DisplayViewModel>();
        }

    }
}

