using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using NotesSimulator.Managers;
using NotesSimulator.Tools;
using NotesSimulator.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace NotesSimulator
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
            mainWindowViewModel.StartApplication();

        }

        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }
    }
}
