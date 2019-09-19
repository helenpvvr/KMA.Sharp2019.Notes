using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotesSimulator.ViewModel
{
    class AllNotesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Note> _notes;

        public AllNotesViewModel() {
            _notes = new ObservableCollection<Note>
            {
                new Note("Note01", "Text01", DateTime.Now),
                new Note("Note02", "Text02", DateTime.Now),
                new Note("Note03", "Text03", DateTime.Now)
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
