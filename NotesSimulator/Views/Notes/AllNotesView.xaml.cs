using System.Windows.Controls;
using NotesSimulator.ViewModel;

namespace NotesSimulator.Views.Notes
{
    /// <summary>
    /// Interaction logic for AllNotesView.xaml
    /// </summary>
    public partial class AllNotesView : UserControl
    {
        public AllNotesView()
        {
            InitializeComponent();
            DataContext = new AllNotesViewModel();
        }
    }
}
