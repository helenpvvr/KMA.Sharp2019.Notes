using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;
using System.Windows.Controls;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Notes
{
    /// <summary>
    /// Interaction logic for NoteView.xaml
    /// </summary>
    internal partial class NoteView : UserControl
    {
        internal NoteView()
        {
            InitializeComponent();
            DataContext = new NoteViewModel();
        }
        
    }
}
