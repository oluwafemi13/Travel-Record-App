using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Travel_Record_App.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_Record_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                
                connection.CreateTable<Post>();
                var post = connection.Table<Post>().ToList();
                HistoryDataView.ItemsSource = post;
                //connection.Close();

            }

            try
            {
                using (SqlConnection connection = new SqlConnection(App.DatabaseLocation))
                {
                    //open connection
                    connection.Open();

                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    command.Connection = connection;
                    command.CommandText = SelectQuery;
                    var result = command.ExecuteReader();
                    //check if account exists
                    var exists = result.HasRows;
                }
            }
            catch (Exception exception)
            {
                #region connection error
                AlertDialog.Builder connectionException = new AlertDialog.Builder(this);
                connectionException.SetTitle("Connection Error");
                connectionException.SetMessage(exception.ToString());
                connectionException.SetNegativeButton("Return", delegate { });
                connectionException.Create();
                connectionException.Show();
                #endregion
            }
        }
    }
}