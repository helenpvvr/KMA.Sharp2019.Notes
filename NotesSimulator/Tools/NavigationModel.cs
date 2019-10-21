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
        private SignInView _signInView;
        private SignUpView _signUpView;
        private AllNotesView _allNotesView;
        private NoteView _noteView;

        internal NavigationModel(IContentWindow contentWindow)
        {
            _contentWindow = contentWindow;
        }

        internal void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.SignIn:
                    _contentWindow.ContentControl.Content = _signInView = new SignInView();//_signInView ?? (_signInView = new SignInView());
                    break;
                case ModesEnum.SingUp:
                    _contentWindow.ContentControl.Content = new SignUpView(); // _signUpView ?? (_signUpView = new SignUpView());
                    break;
                case ModesEnum.AllNotes:
                    _contentWindow.ContentControl.Content = new AllNotesView(); // _allNotesView ?? (_allNotesView = new AllNotesView());
                    break;
                case ModesEnum.NoteDetail:
                    _contentWindow.ContentControl.Content = new NoteView(); //_noteView ?? ((_noteView) = new NoteView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

    }
}
