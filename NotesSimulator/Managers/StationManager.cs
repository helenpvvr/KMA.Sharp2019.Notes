using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using NotesSimulator.DataStorage;
using System;
using System.Windows;

namespace NotesSimulator.Managers
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        private static IDataStorage _dataStorage;

        internal static User CurrentUser { get; set; }
        internal static Note CurrentNote { get; set; }

        internal static IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            StopThreads?.Invoke();
            Environment.Exit(1);
        }
    }
}