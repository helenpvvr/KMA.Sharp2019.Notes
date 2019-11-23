using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    internal class AllNotesViewModel : BaseViewModel
    {
        private ObservableCollection<Note> _notes;
        private RelayCommand<object> _signOutCommand;
        private RelayCommand<object> _addNoteCommand;
        private RelayCommand<object> _editNoteCommand;
        private RelayCommand<object> _deleteNoteCommand;

        private Note _selectedNote;

        internal AllNotesViewModel() {
            _notes = new ObservableCollection<Note>(StationManager.CurrentUser.Notes);
        }

        public ObservableCollection<Note> Notes
        {
            get =>_notes;
            private set { _notes = value; OnPropertyChanged(); }
        }

        public string UserLogin
        {
            get => StationManager.CurrentUser.Login;
        }

        public ICommand SignOutCommand
        {
            get { return _signOutCommand ?? (_signOutCommand = new RelayCommand<object>(SignOutImplementation)); }
        }

        public ICommand AddNoteCommand
        {
            get { return _addNoteCommand ?? (_addNoteCommand = new RelayCommand<object>(AddNoteImplementation)); }
        }

        public ICommand DeleteNoteCommand
        {
            get { return _deleteNoteCommand ?? (_deleteNoteCommand = new RelayCommand<object>(DeleteNoteImplementation)); }
        }
        public ICommand EditNoteCommand
        {
            get { return _editNoteCommand ?? (_editNoteCommand = new RelayCommand<object>(EditNoteImplementation)); }
        }

        public Note SelectedNote
        {
            private get { return _selectedNote; }
            set
            {
                _selectedNote = value;
                OnPropertyChanged();
            }
        }

        private void SignOutImplementation(object obj)
        {
            StationManager.CurrentUser = null;
            SerializationManager.DeleteSerialization(FileFolderHelper.StorageFilePath);
            NavigationManager.Instance.Navigate(ModesEnum.SignIn);
        }

        private void AddNoteImplementation(object obj)
        {
            StationManager.CurrentNote = null;
            NavigationManager.Instance.Navigate(ModesEnum.NoteDetail);
        }

        private async void DeleteNoteImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
               bool res = ConnectionManager.DeleteNote(SelectedNote);
                    if (res)
                    {
                        StationManager.CurrentUser.Notes.RemoveAll(n => n.Guid == SelectedNote.Guid);
                        Notes = new ObservableCollection<Note>(StationManager.CurrentUser.Notes);
                        SelectedNote = null;
                        StationManager.CurrentNote = null;
                    }
                    else
                    {
                        MessageBox.Show("Deleting note was failed.");
                    }
            });
            LoaderManager.Instance.HideLoader();
        }

        private void EditNoteImplementation(object obj)
        {
            StationManager.CurrentNote = SelectedNote;
            NavigationManager.Instance.Navigate(ModesEnum.NoteDetail);
        }
    }
}
