using System.Windows.Controls;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Notes
{
    /// <summary>
    /// Interaction logic for AllNotesView.xaml
    /// </summary>
    internal partial class AllNotesView : UserControl
    {
        internal AllNotesView()
        {
            InitializeComponent();
            DataContext = new AllNotesViewModel();
        }
    }
}
