using System;
using System.IO;
using App1.Data;
using App1.Model;
using Xamarin.Forms;

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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}