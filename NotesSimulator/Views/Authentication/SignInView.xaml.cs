using System.Windows.Controls;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Authentication
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    internal partial class SignInView : UserControl
    {
        internal SignInView()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
