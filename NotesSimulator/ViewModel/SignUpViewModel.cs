using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    class SignUpViewModel : INotifyPropertyChanged
    {
        private string _login;
        private string _password;
        private string _email;

        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _signInCommand;

        public SignUpViewModel()
        {
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public ICommand SignUpCommand
        {
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUpInplementation)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignInImplementation)); }
        }

        private void SignInImplementation(object obj)
        {
            NavigationManager.Instance.Navigate(ModesEnum.SignIn);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void SignUpInplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                User currentUser;
                try
                {
                    currentUser = StationManager.DataStorage.GetUserByLogin(_login);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sign In failed fo user {_login}. Reason:{Environment.NewLine}{ex.Message}");
                    return false;
                }
                if (currentUser != null)
                {
                    MessageBox.Show(
                        $"Sign Up failed fo user {_login}. Reason:{Environment.NewLine}User with sucn name exists.");
                    return false;
                }
                return true;
            });
            LoaderManager.Instance.HideLoader();
            if (!result)
                return;
            StationManager.CurrentUser = new User(Login, Email, Password);
            MessageBox.Show($"User with name {_login} was created");
            NavigationManager.Instance.Navigate(ModesEnum.AllNotes);
        }
        
    }
}
