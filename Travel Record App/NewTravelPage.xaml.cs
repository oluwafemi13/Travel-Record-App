using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travel_Record_App.Model;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Travel_Record_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void save_Clicked(object sender, EventArgs e)
        {
            
            Post post = new Post();
            post.Experience = enterExperience.Text;

            //create sqlite connection
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {

                //create post table
                connection.CreateTable<Post>();
                //insert into table
                int check = connection.Insert(post);
                //close sqlite connection
               // connection.Close();

                if (check > 0)
                {
                    DisplayAlert("Successful", "Save Successful", "ok");
                    

                }
                else
                    DisplayAlert("Failed", "Save Failed", "ok");
            }

               
        }
    }
}