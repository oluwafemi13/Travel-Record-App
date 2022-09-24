using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Travel_Record_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void login_Clicked(object sender, EventArgs e)
        {
            //bool isLoggedIn = false;
            //bool isLoggedOut = false;
            bool isusernameEmpty = string.IsNullOrEmpty(username.Text);
            bool ispasswordEmpty = string.IsNullOrEmpty(password.Text);

            if (isusernameEmpty || ispasswordEmpty)
            {
                DisplayAlert(Title, "incorrect or incomplete information", cancel: "cancel");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
            /*Navigation.PushAsync(new HomePage());*/
        }

        private void register_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());   
        }
    }
}
