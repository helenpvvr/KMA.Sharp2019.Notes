using NotesSimulator.ViewModel;
using System.Windows.Controls;

namespace NotesSimulator.Views.Authentication
{
    /// <summary>
    /// Interaction logic for SingUpView.xaml
    /// </summary>
    internal partial class SingUpView : UserControl
    {
        internal SingUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }
    }
}
