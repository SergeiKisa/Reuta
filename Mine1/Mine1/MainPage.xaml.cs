using Mine1.ViewsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mine1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.BindingContext = new MainPageViewModel();
		}
	}
}
