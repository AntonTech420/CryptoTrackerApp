using System;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private string apiKey = "B8A8313A-F405-461D-8D2E-551C814FB74F";
        private string baseImageUrl = "https://s3.eu-central-1.amazonaws.com/bbxt-static-icons/type-id/png_64/";
        private string extraAdd = "";

        public MainPage()
        {
            InitializeComponent();

            var client = new RestClient("https://rest.coinapi.io/v1/assets?filter_asset_id=BTC;ETH;XMR;LTC;USDT" + extraAdd);
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-CoinAPI-Key", apiKey);
            IRestResponse response = client.Execute(request);

        }

       
    }
}