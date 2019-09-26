using System.Windows.Controls;
using NotesSimulator.ViewModel;

namespace NotesSimulator.Views.Authentication
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
