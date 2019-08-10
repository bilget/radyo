﻿using Radio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Radio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StreamPage : ContentPage
	{
        BroadcastViewModel vm;
		public StreamPage ()
		{
			InitializeComponent ();
            vm = new BroadcastViewModel();
            listBroadcast.ItemsSource = vm.Broadcasts;
		}
	}
}