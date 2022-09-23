﻿using Microsoft.Data.Sqlite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
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

            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            
                connection.CreateTable<Post>();
                var post = connection.Table<Post>().ToList();
                HistoryDataView.ItemsSource = post;
                connection.Close();  
            

        }
    }
}