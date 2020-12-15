using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlankApp.Models
{
    public class Person:INotifyPropertyChanged
    {

        

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Xamarin.Forms.Color bgColor = Xamarin.Forms.Color.Blue;
        public Xamarin.Forms.Color BgColor
        {
            get { return bgColor; }
            set 
            { 
                bgColor = value;
                OnPropertyChanged("BgColor");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));       
        
        }

    }
}
