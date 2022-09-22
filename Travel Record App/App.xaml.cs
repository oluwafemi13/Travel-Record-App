using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_Record_App
{
    public partial class App : Application
    {
        //private static string database { get; set; }
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            //navigation page is used to move from one page front and back
            MainPage = new NavigationPage(new MainPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            //navigation page is used to move from one page front and back
            MainPage = new NavigationPage(new MainPage());
            //database = databaseLocation;
            DatabaseLocation = databaseLocation;

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
