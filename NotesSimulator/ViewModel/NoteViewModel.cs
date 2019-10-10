using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using NotesSimulator.Tools;

namespace NotesSimulator.ViewModel
{
    class NoteViewModel : INotifyPropertyChanged
    {
        private DateTime? _createdDateTime;
        private DateTime? _editedDateTime;
        private string _title;
        private string _noteField;
        private string _userLogin;

        private RelayCommand<object> _returnToAllNotesCommand;

        public DateTime? CreatedDateTime
        {
            get => _createdDateTime;
            set
            {
                _createdDateTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime? EditedDateTime
        {
            get => _editedDateTime;
            set
            {
                _editedDateTime = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string NoteField
        {
            get => _noteField;
            set
            {
                _noteField = value;
                OnPropertyChanged();
            }
        }

        public string Dates
        {
            get
            {
                return "Created: " + CreatedDateTime.ToString() + 
                         ((EditedDateTime != CreatedDateTime) ? " / Last edited: " + EditedDateTime.ToString() : "");
            }
        }

        public string UserLogin
        {
            get => _userLogin;
            set
            {
                _userLogin = value;
                OnPropertyChanged();
            }
        }

        public NoteViewModel()
        {
            // TODO init fileds
            EditedDateTime = DateTime.Now;
            CreatedDateTime = DateTime.Today;
            Title = "Title Test";
            NoteField = "The Cisco Borderless Network provides the framework to " +
                        "unify wired and wireless access, including policy, access control, " +
                        "and performance management across many different device types. Using " +
                        "this architecture, the borderless network is built on a hierarchical infrastructure of " +
                        "hardware that is scalable and resilient, as shown in the figure. By combining this hardware " +
                        "infrastructure with policy-based software solutions, the Cisco Borderless Network provides " +
                        "two primary sets of services: network services, and user and endpoint services that are all " +
                        "managed by an integrated management solution. It enables different network elements to work " +
                        "together, and allows users to access resources from any place, at any time, while providing optimization, scalability, and security. The Cisco Borderless Network provides the framework to unify wired and wireless access, including policy, access control, and performance management across many different device types. Using this architecture, the borderless network is built on a hierarchical infrastructure of hardware that is scalable and resilient, as shown in the figure. By combining this hardware infrastructure with policy-based software solutions, the Cisco Borderless Network provides two primary sets of services: network services, and user and endpoint services that are all managed by an integrated management solution. It enables different network elements to work together, and allows users to access resources from any place, at any time, while providing optimization, scalability, and security. The Cisco Borderless Network provides the framework to unify wired and wireless access, including policy, access control, and performance management across many different device types. Using this architecture, the borderless network is built on a hierarchical infrastructure of hardware that is scalable and resilient, as shown in the figure. By combining this hardware infrastructure with policy-based software solutions, the Cisco Borderless Network provides two primary sets of services: network services, and user and endpoint services that are all managed by an integrated management solution. It enables different network elements to work together, and allows users to access resources from any place, at any time, while providing optimization, scalability, and security. The Cisco Borderless Network provides the framework to unify wired and wireless access, including policy, access control, and performance management across many different device types. Using this architecture, the borderless network is built on a hierarchical infrastructure of hardware that is scalable and resilient, as shown in the figure. By combining this hardware infrastructure with policy-based software solutions, the Cisco Borderless Network provides two primary sets of services: network services, and user and endpoint services that are all managed by an integrated management solution. It enables different network elements to work together, and allows users to access resources from any place, at any time, while providing optimization, scalability, and security.";
        }

        public ICommand ReturnToAllNotesCommand
        {
            get
            {
                return _returnToAllNotesCommand ?? (_returnToAllNotesCommand = new RelayCommand<object>(OpenAllNotes));
            }
        }

        private void OpenAllNotes(object obj)
        {
            // TODO save changes and change view
            MessageBox.Show("You click return button");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
