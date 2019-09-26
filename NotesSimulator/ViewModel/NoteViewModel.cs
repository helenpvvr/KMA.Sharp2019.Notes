using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
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

        public NoteViewModel()
        {
            // TODO init fileds
            EditedDateTime = DateTime.Now;
            CreatedDateTime = DateTime.Today;
            Title = "Title Test";
            NoteField = "Do smth";
        }

        public ICommand ReturnToAllNotesCommand
        {
            get
            {
                return _returnToAllNotesCommand ?? (_returnToAllNotesCommand = new RelayCommand<object>(OpenAllNotes));
            }
        }

        private void OpenAllNotes(object obj)
        {
            // TODO save changes and change view
            MessageBox.Show("You click return button");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
