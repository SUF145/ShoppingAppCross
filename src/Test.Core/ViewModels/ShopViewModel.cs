using System;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using RestSharp;
using RestSharp.Serializers;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Test.Core.ViewModels
{
    public class ShopViewModel : MvxViewModel
    {
        private ObservableCollection<Tshirt> _tshirtsList;
        public ObservableCollection<Tshirt> TshirtsList
        {
            get => _tshirtsList;
            set => SetProperty(ref _tshirtsList, value);
        }

        public IMvxNavigationService _navigationService;
        public ShopViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private IMvxAsyncCommand _buyNowCommand;
        public IMvxAsyncCommand BuyNowCommand
        {
            get
            {
                _buyNowCommand = new MvxAsyncCommand(async () =>
                {
                    await BuyNowCommandAsync();
                });
                return _buyNowCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            //PostMethod();
            var client = new RestClient("https://mocki.io/v1/");
            var resource = "642479ba-3c2e-4c4d-9951-9654723dbeca";
            var request = new RestRequest(resource, Method.Get);

            var response = await client.ExecuteAsync<List<Tshirt>>(request);
            var result = JsonConvert.DeserializeObject<List<Tshirt>>(response.Content);

            TshirtsList = new ObservableCollection<Tshirt>(result);

        }
        private async Task BuyNowCommandAsync()
        {
            await _navigationService.Navigate<BuyNowViewModel>();
        }

        public async void PostMethod()
        {
            var client = new RestClient("https://mocki.io/v1/");
            var resource = "642479ba-3c2e-4c4d-9951-9654723dbeca";
            var request = new RestRequest(resource, Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Tshirt { Name = "Odisha", Description = "Black Polyester Tshirt", Price = 100, ImageUrl = "https://www.mydesignation.com/wp-content/uploads/2019/12/manushyan-tshirt-mydesignation-mockup-latest-image-.jpg" });
            var result = await client.PostAsync<Tshirt>(request);

        }

    }

    public class Tshirt
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}

