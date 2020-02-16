using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IndicatorViewPopup.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
        }
    
        public void Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            field = newValue;
            NotifyPropertyChanged(propertyName);
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

