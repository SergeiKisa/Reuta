using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace Mine1.ViewsModels
{
	class MainPageViewModel : BaseViewModel
	{
		public ICommand command { get; set; }

		private Color currentBGcolor;
		public Color BG_color { get { return currentBGcolor; } set { currentBGcolor = value; NotifyPropertyChanged("BG_color"); } }
		
		private Color newBGcolor = Color.Bisque;
		private Color standart = Color.Chocolate;

		string txt;
		public string Txt { get { return txt; } set { txt = value; NotifyPropertyChanged("Txt"); } }

		public MainPageViewModel()
		{
			txt = "Kisenko S.S.";
			BG_color = standart;
			command = new Command(FirstCommand);
		}

		public void FirstCommand()
		{
			if (BG_color != newBGcolor) {
				BG_color = newBGcolor;
			}
			else
			{
				BG_color = standart;
			}
		}
	}
}
