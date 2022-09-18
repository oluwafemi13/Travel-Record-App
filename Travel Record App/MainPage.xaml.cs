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

            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {

            }
            else
            {

            }
        }

        private void register_Clicked(object sender, EventArgs e)
        {

        }
    }
}
