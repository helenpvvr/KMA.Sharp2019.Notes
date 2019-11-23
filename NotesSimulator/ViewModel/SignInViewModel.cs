﻿using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    internal class SignInViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _signInCommand;


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

        public ICommand SignUpCommand
        {
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUpImplementation)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignInImplementation, SignInCanExecute)); }
        }

        internal SignInViewModel()
        {

        }

        private bool SignInCanExecute(object obj)
        {
            return !String.IsNullOrEmpty(_login) &&
                   !String.IsNullOrEmpty(_password);
        }

        private void SignUpImplementation(object obj)
        {
            NavigationManager.Instance.Navigate(ModesEnum.SingUp);
        }

        private async void SignInImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                User currentUser = ConnectionManager.GetUserByLogin(_login);
                if (currentUser == null)
                {
                    MessageBox.Show(
                        $"Sign In failed fo user {_login}. Reason:{Environment.NewLine}Wrong password or user doesn't exist.");
                    return false;
                }
                if (!currentUser.CheckPassword(_password))
                {
                    MessageBox.Show($"Sign In failed fo user {_login}. Reason:{Environment.NewLine}Wrong password or user doesn't exist.");
                    return false;
                }
                StationManager.CurrentUser = currentUser;
                MessageBox.Show($"Sign In successful fo user {_login}.");
                return true;
            });
            LoaderManager.Instance.HideLoader();
            if (result)
            {
                StationManager.CurrentUser.LastSingInDate= DateTime.Now;
                ConnectionManager.SaveUser(StationManager.CurrentUser);
                SerializationManager.Serialize(StationManager.CurrentUser.Guid.ToString(), FileFolderHelper.StorageFilePath);
                NavigationManager.Instance.Navigate(ModesEnum.AllNotes);
            }
        }


    }
}
