using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    internal class SignUpViewModel : BaseViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _login;
        private string _password;
        private string _email;

        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _signInCommand;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value.Replace(" ", "");
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value.Replace(" ", "");
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value.Replace(" ", "");
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
                _email = value.Replace(" ", "");
                OnPropertyChanged();
            }
        }

        public ICommand SignUpCommand
        {
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUpImplementation, SignUpCanExecute)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignInImplementation)); }
        }

        internal SignUpViewModel()
        {

        }

        private void SignInImplementation(object obj)
        {
            NavigationManager.Instance.Navigate(ModesEnum.SignIn);
        }

        private bool SignUpCanExecute(object obj)
        {
            return !String.IsNullOrEmpty(_firstName) &&
                   !String.IsNullOrEmpty(_lastName) &&
                   !String.IsNullOrEmpty(_login) &&
                   !String.IsNullOrEmpty(_password) &&
                   !String.IsNullOrEmpty(_email);
        }

        private async void SignUpImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                if (!new EmailAddressAttribute().IsValid(_email))
                {
                    MessageBox.Show($"Sign Up failed. Email {_email} is not valid.");
                    return false;
                }
                User currentUser = ConnectionManager.GetUserByLogin(_login);
                if (currentUser != null)
                {
                    MessageBox.Show(
                        $"Sign Up failed fo user {_login}. Reason:{Environment.NewLine}User with sucn name exists.");
                    return false;
                }
                return true;
            });
          
            if (!result)
            {
                LoaderManager.Instance.HideLoader();
                return;

            }
            StationManager.CurrentUser = new User(FirstName, LastName, Login, Email, Password);
            bool res  = ConnectionManager.AddUser(StationManager.CurrentUser);
            LoaderManager.Instance.HideLoader();
            if (res)
            {
                MessageBox.Show($"User with name {_login} was created");
                NavigationManager.Instance.Navigate(ModesEnum.AllNotes);
            }
            else
            {
                MessageBox.Show($"User was not created");
            }
        }
        
    }
}
