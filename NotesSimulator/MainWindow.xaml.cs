using System.Windows;

namespace NotesSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*var navigationModel = new NavigationModel(this);
            NavigationManager.Instance.Initialize(navigationModel);
            StationManager.Initialize(new DataStorage.DataStorage());

            StationManager.DataStorage.AddUser(new User("111", "111", "111"));
            User user = StationManager.DataStorage.GetUserByLogin("111");
            user.Notes = new List<Note>()
            {
                new Note("Finish MOOP", "FINISH!!!", new DateTime(2019, 10, 2)),
                new Note("Go to shop", "...", DateTime.Now)
            };

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.StartApplication();*/

        }

        //public ContentControl ContentControl
        //{
        //    get { return _contentControl; }
        //}
    }
}
