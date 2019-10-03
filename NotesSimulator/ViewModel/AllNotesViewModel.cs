using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NotesSimulator.Managers;

namespace NotesSimulator.ViewModel
{
    class AllNotesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Note> _notes;

        public AllNotesViewModel() {
            //_notes = new ObservableCollection<Note>(StationManager.CurrentUser.Notes);
            _notes = new ObservableCollection<Note>()
            {
                new Note("Note 1", "Text to note 1", DateTime.Now),
                new Note("Note 2", "Text to note 2 LONG LONG LONG LONG LOOOOOOOOOOOOOOOOOOOONG LONG LONG LONG LONG LOOOOOOOOOOOOOOOOOOOONG", DateTime.Today)
            };
        }

        public ObservableCollection<Note> Notes
        {
            get =>_notes;
            set { _notes = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
