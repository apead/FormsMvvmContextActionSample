using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using MvvmContextActionSample.ViewModels;
using MvvmContextActionSample.Views.ViewCells;
using Xamarin.Forms;

namespace MvvmContextActionSample.Views
{
    public class ListViewContextActionCode : ContentPage
    {
        public ListViewContextActionCode()
        {

            var vm = new SampleViewModel();
            BindingContext = vm;

            var listview = new ListView();

            listview.ItemsSource = vm.SampleList; 
            listview.ItemTemplate = new DataTemplate(() => new SampleViewCell(this));

            Content = listview;
        }
    }
}
