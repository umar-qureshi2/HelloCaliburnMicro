using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserFlow.ViewModels.Journaling
{
    public class JournalViewModel : Caliburn.Micro.PropertyChangedBase
    {
        private bool _canDisplayNote;
        private string _note = string.Empty;
        private string _noteDisplay = string.Empty;

        public JournalViewModel()
        {

        }

        ///
        /// Indicates whether or not the Note can be displayed.
        ///
        public bool CanDisplayNote
        {
            get { return _canDisplayNote; }
            set
            {
                _canDisplayNote = value;
                NotifyOfPropertyChange(() => CanDisplayNote);
            }
        }

        ///
        /// The Journal's Note.
        ///
        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                NotifyOfPropertyChange(() => Note);
            }
        }

        ///
        /// The note to display.
        ///
        public string NoteDisplay
        {
            get { return _noteDisplay; }
            set
            {
                _noteDisplay = value;
                NotifyOfPropertyChange(() => NoteDisplay);
            }
        }

        ///
        /// Displays the note.
        ///
        public void DisplayNote()
        {
            NoteDisplay = Note;
        }
    }
}
