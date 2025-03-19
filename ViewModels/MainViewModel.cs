using System.ComponentModel;

namespace ComunidadeCulinaria.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
public event PropertyChangedEventHandler? PropertyChanged;

        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
