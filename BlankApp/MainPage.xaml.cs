using BlankApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlankApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Person> Items { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Person>();
            Items.Add(new Person { Id = 1, Name = "Ali" });
            Items.Add(new Person { Id = 2, Name = "Ayşe" });
            Items.Add(new Person { Id = 3, Name = "Adem" });

            this.BindingContext = this;
            
        }

        private  void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPerson = e.SelectedItem as Person;
            var person = Items.FirstOrDefault(x => x.Id == selectedPerson.Id);
            person.BgColor = Xamarin.Forms.Color.Green;
            //await DisplayAlert("ddd","asdsd","asas");


        }
    }
}
