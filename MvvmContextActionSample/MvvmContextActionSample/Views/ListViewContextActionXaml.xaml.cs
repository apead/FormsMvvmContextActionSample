using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmContextActionSample.ViewModels;
using Xamarin.Forms;

namespace MvvmContextActionSample
{
    public partial class ListViewContextActionXaml : ContentPage
    {
        public ListViewContextActionXaml()
        {
            InitializeComponent();

            BindingContext = new SampleViewModel();
        }
    }
}
