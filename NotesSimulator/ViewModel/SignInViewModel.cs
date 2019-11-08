using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    class SignInViewModel : BaseViewModel
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
            get { return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(SignUpImplementation)); }
        }

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new RelayCommand<object>(SignInImplementation)); }
        }

        private void SignUpImplementation(object obj)
        {
                 
            NotesWcfServiceReference.NotesServiceClient client = new NotesServiceClient();
            
            //MessageBox.Show(client.DoWork());
            NavigationManager.Instance.Navigate(ModesEnum.SingUp);
        }

        private async void SignInImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                User currentUser = null;
                using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
                {
                    INotesService client = myChannelFactory.CreateChannel();
                    MessageBox.Show(client.GetUserByLogin(_login, _password));
                    return true;
                }

                //try
                //{ 
                //    currentUser = EntityWrapper.UserByLogin(_login);
                //    // TODO delete reference to DBAdapter and use DBManager
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Sign In failed fo user {_login}. Reason:{Environment.NewLine}{ex.Message}");
                //    return false;
                //}
                if (currentUser == null)
                {
                    MessageBox.Show(
                        $"Sign In failed fo user {_login}. Reason:{Environment.NewLine}User does not exist.");
                    return false;
                }
                if (!currentUser.CheckPassword(_password))
                {
                    MessageBox.Show($"Sign In failed fo user {_login}. Reason:{Environment.NewLine}Wrong Password.");
                    return false;
                }
                //if (currentUser == null) return false;

                StationManager.CurrentUser = currentUser;
                MessageBox.Show($"Sign In successful fo user {_login}.");
                return true;
            });
            LoaderManager.Instance.HideLoader();
            if (result)
                NavigationManager.Instance.Navigate(ModesEnum.AllNotes);
        }


    }
}
