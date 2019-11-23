using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using System;
using System.Windows;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        internal static User CurrentUser { get; set; }
        internal static Note CurrentNote { get; set; }

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            StopThreads?.Invoke();
            Environment.Exit(1);
        }
    }
}