using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;
using System.Windows.Controls;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Notes
{
    /// <summary>
    /// Interaction logic for NoteView.xaml
    /// </summary>
    public partial class NoteView : UserControl
    {
        public NoteView()
        {
            InitializeComponent();
            DataContext = new NoteViewModel();
        }
        
    }
}
