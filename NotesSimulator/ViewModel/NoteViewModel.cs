using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel
{
    class NoteViewModel : BaseViewModel
    {
        private DateTime? _createdDateTime;
        private DateTime? _editedDateTime;
        private string _title;
        private string _noteField;

        private RelayCommand<object> _returnToAllNotesCommand;
        private RelayCommand<object> _saveNoteCommand;

        public DateTime? CreatedDateTime
        {
            get => _createdDateTime;
            set
            {
                _createdDateTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime? EditedDateTime
        {
            get => _editedDateTime;
            set
            {
                _editedDateTime = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string NoteField
        {
            get => _noteField;
            set
            {
                _noteField = value;
                OnPropertyChanged();
            }
        }

        public string UserLogin
        {
            get => StationManager.CurrentUser.Login;
        }

        public NoteViewModel()
        {
            if (StationManager.CurrentNote == null)
            {
                StationManager.CurrentNote = new Note("", "", StationManager.CurrentUser);
                ConnectionManager.AddNote(StationManager.CurrentNote);
                EditedDateTime = null;
            }
            else
            {
                EditedDateTime = StationManager.CurrentNote.EditedDateTime;
            }

            Title = StationManager.CurrentNote.Title;
            NoteField = StationManager.CurrentNote.NoteText;
            CreatedDateTime = StationManager.CurrentNote.CreatedDateTime;
        }

        public ICommand ReturnToAllNotesCommand
        {
            get
            {
                return _returnToAllNotesCommand ?? (_returnToAllNotesCommand = new RelayCommand<object>(OpenAllNotes));
            }
        }

        public ICommand SaveNoteCommand
        {
            get
            {
                return _saveNoteCommand ?? (_saveNoteCommand = new RelayCommand<object>(SaveNote));
            }
        }

        private void OpenAllNotes(object obj)
        {
            NavigationManager.Instance.Navigate(ModesEnum.AllNotes);
        }

        private async void SaveNote(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            var result = await Task.Run(() =>
            {
                try
                {
                    StationManager.CurrentNote.Title = Title;
                    StationManager.CurrentNote.NoteText = NoteField;
                    StationManager.CurrentNote.EditedDateTime = DateTime.Now;
                    ConnectionManager.SaveNote(StationManager.CurrentNote);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Saving note was failed. Reason:{Environment.NewLine}{ex.Message}");
                    return false;
                }
            });
            LoaderManager.Instance.HideLoader();
            if(result)
                EditedDateTime = StationManager.CurrentNote.EditedDateTime;
        }

    }
}
