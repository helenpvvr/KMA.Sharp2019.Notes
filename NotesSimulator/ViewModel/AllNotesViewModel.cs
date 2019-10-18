using System;
using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using NotesSimulator.Managers;
using NotesSimulator.Tools;
using System.Windows.Input;

namespace NotesSimulator.ViewModel
{
    class AllNotesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Note> _notes;
        private RelayCommand<object> _signOutCommand;
        private RelayCommand<object> _addNoteCommand;
        private RelayCommand<object> _editNoteCommand;
        private RelayCommand<object> _deleteNoteCommand;
        private RelayCommand<object> _helpCommand;

        private Note _selectedNote;

        public AllNotesViewModel() {
            _notes = new ObservableCollection<Note>(StationManager.CurrentUser.Notes);
        }

        public ObservableCollection<Note> Notes
        {
            get =>_notes;
            set { _notes = value; OnPropertyChanged(); }
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

        public ICommand HelpCommand
        {
            get { return _helpCommand ?? (_helpCommand = new RelayCommand<object>(HelpImplementation)); }
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
            NavigationManager.Instance.Navigate(ModesEnum.SignIn);
        }

        private void AddNoteImplementation(object obj)
        {
            StationManager.CurrentNote = null;
            NavigationManager.Instance.Navigate(ModesEnum.NoteDetail);
        }

        private void DeleteNoteImplementation(object obj)
        {
            // in new Thread
            StationManager.CurrentUser.RemoveNote(SelectedNote);
            Notes = new ObservableCollection<Note>(StationManager.CurrentUser.Notes);

            SelectedNote = null;
            StationManager.CurrentNote = null;
        }

        private void EditNoteImplementation(object obj)
        {
            StationManager.CurrentNote = SelectedNote;
            NavigationManager.Instance.Navigate(ModesEnum.NoteDetail);
        }

        private void HelpImplementation(object obj)
        {
            MessageBox.Show("Help");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
