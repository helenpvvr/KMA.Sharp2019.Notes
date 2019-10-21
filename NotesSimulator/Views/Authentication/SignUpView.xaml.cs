using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;
using System.Windows.Controls;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Authentication
{
    /// <summary>
    /// Interaction logic for SingUpView.xaml
    /// </summary>
    internal partial class SignUpView : UserControl
    {
        internal SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }
    }
}
