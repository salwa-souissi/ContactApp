using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ContactApp.Models
{
    public class Contact : INotifyPropertyChanged
    {
        #region Constructor without parameters
        public Contact()
        {

        }
        #endregion

        #region Constructor with parameters
        public Contact(string name, string gsm)
        {
           
            _name = name;
            _gsm = gsm;
            
        }
        #endregion

      

        #region Property Name
        public string _name;
        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        #endregion

        #region Property GSM
        public string _gsm;

        public string GSM
        {
            get
            {
                return _gsm;

            }
            set
            {
                if (_gsm != value)
                {
                    _gsm = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("GSM"));
                }
            }
        }
        #endregion

        #region Property Image
        public ImageSource _image;

        public ImageSource Image
        {
            get
            {
                return _image;

            }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Image"));
                }
            }
        }
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;






    }
}