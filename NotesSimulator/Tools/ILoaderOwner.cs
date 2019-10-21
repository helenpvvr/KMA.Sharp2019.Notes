using System.Windows;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools
{
    internal interface ILoaderOwner
    {
        Visibility LoaderVisibility { get; set; }
        bool IsEnabled { get; set; }
    }
}