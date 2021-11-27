using System;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using App1.Model;


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

            coinListView.ItemsSource = GetCoins();



        }

        private List<Coin> GetCoins()
        {
            List<Coin> coins;

            var client = new RestClient("http://rest.coinapi.io/v1/assets?filter_asset_id=BTC;ETH;XMR;LTC;USDT" + extraAdd);
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-CoinAPI-Key", apiKey);


            var response = client.Execute(request);
            coins = JsonConvert.DeserializeObject<List<Coin>>(response.Content);

            foreach (var c in coins)
            {
                if (!String.IsNullOrEmpty(c.id_icon))
                    c.icon_url = baseImageUrl + c.id_icon.Replace("-", "") + ".png";
                else
                    c.icon_url = "";
            }

            return coins;
 
        }


        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            extraAdd = await DisplayPromptAsync("Add your Currency", "Example: ;BTC;ETH;XMR");
            coinListView.ItemsSource = GetCoins();
        }

        private void RefreshButton_Clicked(object sender, EventArgs e)
        {
            coinListView.ItemsSource = GetCoins();
        }
    }
}