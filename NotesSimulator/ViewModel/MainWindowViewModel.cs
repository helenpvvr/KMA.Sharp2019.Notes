using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    public class MainWindowViewModel : ILoaderOwner
    {
        private Visibility _visibility = Visibility.Visible;
        private bool _isEnabled = true;

        public Visibility LoaderVisibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            LoaderManager.Instance.Initialize(this);
        }

        internal void StartApplication()
        {
            NavigationManager.Instance.Navigate(StationManager.CurrentUser != null ? ModesEnum.AllNotes : ModesEnum.SignIn);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
