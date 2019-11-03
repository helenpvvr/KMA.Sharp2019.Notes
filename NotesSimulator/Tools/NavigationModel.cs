using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Authentication;
using System;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Views.Notes;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools
{
    internal enum ModesEnum
    {
        SignIn,
        SingUp,
        AllNotes,
        NoteDetail
    }

    internal class NavigationModel
    {
        private readonly IContentWindow _contentWindow;

        internal NavigationModel(IContentWindow contentWindow)
        {
            _contentWindow = contentWindow;
        }

        internal void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.SignIn:
                    _contentWindow.ContentControl.Content = new SignInView();
                    break;
                case ModesEnum.SingUp:
                    _contentWindow.ContentControl.Content = new SignUpView();
                    break;
                case ModesEnum.AllNotes:
                    _contentWindow.ContentControl.Content = new AllNotesView(); 
                    break;
                case ModesEnum.NoteDetail:
                    _contentWindow.ContentControl.Content = new NoteView();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

    }
}
