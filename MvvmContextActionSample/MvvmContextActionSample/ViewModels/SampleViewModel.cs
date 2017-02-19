using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MvvmContextActionSample.Annotations;
using MvvmContextActionSample.Models;
using MvvmContextActionSample.Services;
using Xamarin.Forms;

namespace MvvmContextActionSample.ViewModels
{
    public class SampleViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SampleModel> _sampleList;

        public ObservableCollection<SampleModel> SampleList { get { return _sampleList;} set {  _sampleList = value;
            OnPropertyChanged();
        } }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand DeleteSampleCommand { get; set; }

        public SampleViewModel()
        {
            SampleList = new ObservableCollection<SampleModel>(MockSamplesService.GetSamples());

            DeleteSampleCommand = new Command(DeleteSample);
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DeleteSample(object param)
        {
            var model = param as SampleModel;

            if (model != null)
                SampleList.Remove(model);
        }
    }
}
