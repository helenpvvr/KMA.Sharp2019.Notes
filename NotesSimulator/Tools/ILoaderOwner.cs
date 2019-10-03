using System.Windows;

namespace NotesSimulator.Tools
{
    internal interface ILoaderOwner
    {
        Visibility LoaderVisibility { get; set; }
        bool IsEnabled { get; set; }
    }
}