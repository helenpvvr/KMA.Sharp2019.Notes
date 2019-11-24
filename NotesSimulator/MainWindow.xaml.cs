using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.ViewModel;
using System;
using System.Windows.Controls;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IContentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var navigationModel = new NavigationModel(this);
            NavigationManager.Instance.Initialize(navigationModel);
            
            try
            {
                String guid = SerializationManager.Deserialize<String>(FileFolderHelper.StorageFilePath);
                StationManager.CurrentUser = ConnectionManager.GetUserByGuid(guid);
                if (StationManager.CurrentUser != null)
                {
                    StationManager.CurrentUser.LastSingInDate = DateTime.Now;
                    ConnectionManager.SaveUser(StationManager.CurrentUser);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.StartApplication();

        }

        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }

    }
}
