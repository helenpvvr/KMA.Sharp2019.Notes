using System.ComponentModel;
using System.Runtime.CompilerServices;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Properties;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Tools
{
   
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    
}
