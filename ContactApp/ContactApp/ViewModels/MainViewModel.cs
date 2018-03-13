using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using ContactApp.Models;
using ContactApp.Views;
using Xamarin.Forms;

namespace ContactApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Fields
        public INavigation navigation;
        public Command<Object> _tapCommand;
        #endregion

        #region Properties

        public ObservableCollection<Contact> ContactList{ get; set; }

        public Command<Object> TapCommand
        {
            get { return _tapCommand; }
            set { _tapCommand = value; }
        }

        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        #endregion

        #region Constructor with parameters

        public MainViewModel(INavigation _nav)
        {
            Navigation = _nav; ;
            _tapCommand = new Command<object>(OnTapped);
            ContactList = new ObservableCollection<Contact>();
            Random r = new Random();
            foreach (var name in Names)
            {
                var Contact =new Contact(name,r.Next(216,870).ToString()+"-"+r.Next(22222222,22999999));
                Contact._image = ImageSource.FromResource("ContactApp.Images.Image" + r.Next(0, 4) + ".png");
                ContactList.Add(Contact);
            }
            
        }

        #endregion

        #region OnTapped Method Implementation

        public void OnTapped(Object o)
        {
            var nextPage = new DetailPage();
            nextPage.BindingContext = o;
            Navigation.PushAsync(nextPage);
        }

        #endregion

        #region List of Names and Departments  

        private string[] Names = new string[]
        {
            "Mohamed", "Bachir", "Fawzi", "Imen", "Emna", "Salwa",
        };

     
        #endregion

    }


}

