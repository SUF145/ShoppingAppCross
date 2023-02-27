using System;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using System.Collections.ObjectModel;

namespace Test.Core.ViewModels
{
    public class ContactUsViewModel : MvxViewModel
    {
        //public ObservableCollection<string> ContactFormDetails { get; set; }
        private IMvxNavigationService _navigationService;
        public ContactUsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private IMvxAsyncCommand _callBackCommand;
        public IMvxAsyncCommand CallBackCommand
        {
            get
            {
                _callBackCommand = new MvxAsyncCommand(async () =>
                {
                    await CallBackAsync();
                });
                return _callBackCommand;
            }
        }
        private async Task CallBackAsync()
        {
            await _navigationService.Navigate<ShopViewModel>();
        }
    }
}

