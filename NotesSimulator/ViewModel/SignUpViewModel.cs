using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NotesSimulator.Tools;

namespace NotesSimulator.ViewModel
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
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUp)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignIn)); }
        }

        private void SignUp(object obj)
        {
            // TODO написати нормальний код
            // перевірити логін, пароль та емейл
            MessageBox.Show("Login = " + Login + "; Password = " + Password + "; Email = " + Email);
        }

        private void SignIn(object obj)
        {
            // TODO написати нормальний код
            MessageBox.Show("You clicked Sign Ip");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
