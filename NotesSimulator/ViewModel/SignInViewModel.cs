using NotesSimulator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NotesSimulator.ViewModel
{
    class SignInViewModel : INotifyPropertyChanged
    {
        private string _login;
        private string _password;

        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _signInCommand;

        public SignInViewModel()
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

        public ICommand SignUpCommand
        {
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUp)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignIn)); }
        }

        private void SignUp(object obj)
        {
            // TODO написати нормальний код
            MessageBox.Show("You clicked Sign Up");
        }

        private void SignIn(object obj)
        {
            // TODO написати нормальний код
            // перевірити логін та пароль
            MessageBox.Show("Login = " + Login + "; Password = " + Password);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
