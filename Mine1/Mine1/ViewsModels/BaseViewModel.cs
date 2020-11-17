using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mine1.ViewsModels
{
	class BaseViewModel : INotifyPropertyChanged
	{
			public event PropertyChangedEventHandler PropertyChanged;

			protected void NotifyPropertyChanged(string name)
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
			}
		
	}
}
