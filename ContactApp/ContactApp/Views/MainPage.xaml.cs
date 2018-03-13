using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.ViewModels;
using Xamarin.Forms;

namespace ContactApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    MainViewModel homevm = new MainViewModel(this.Navigation);
		    this.BindingContext = homevm;
        }
	}
}
