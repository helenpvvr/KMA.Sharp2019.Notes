using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using NotesSimulator.Managers;
using NotesSimulator.Tools;

namespace NotesSimulator.ViewModel
{
    class NoteViewModel : INotifyPropertyChanged
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

        public string Dates
        {
            get
            {
                return "Created: " + CreatedDateTime.ToString() + 
                         ((EditedDateTime != CreatedDateTime) ? " / Last edited: " + EditedDateTime.ToString() : "");
            }
        }

        public string UserLogin
        {
            get => StationManager.CurrentUser.Login;
        }

        public NoteViewModel()
        {
            if (StationManager.CurrentNote == null)
                StationManager.CurrentNote = new Note();

            Title = StationManager.CurrentNote.Name;
            NoteField = StationManager.CurrentNote.Text;
            CreatedDateTime = StationManager.CurrentNote.CreatedDateTime;
            EditedDateTime = StationManager.CurrentNote.EditedDateTime;
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
            // TODO if there may be any mistake
            await Task.Run(() =>
            {
                Thread.Sleep(100);
                StationManager.CurrentNote.Name = Title;
                StationManager.CurrentNote.Text = NoteField;
                StationManager.CurrentNote.EditedDateTime = DateTime.Now;
                if (StationManager.CurrentUser.Notes.Where(n => n.Guid == StationManager.CurrentNote.Guid).ToList().Count == 0)
                    StationManager.CurrentUser.Notes.Add(StationManager.CurrentNote);
            });
            LoaderManager.Instance.HideLoader();
            EditedDateTime = StationManager.CurrentNote.EditedDateTime; // not show. why?
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
