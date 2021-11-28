using System;
using System.IO;
/*using App1.Data;*/
using App1.Model;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace App1
{
    public partial class App : Application
    {
       /* static CryptoDatabase database;*/

        // Create the database connection as a singleton.
        /*public static CryptoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CryptoDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }*/
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=80baced3-8f5e-42ae-ac3e-bb48fe21bae8;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
           /* Crashes.GenerateTestCrash();*/
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}