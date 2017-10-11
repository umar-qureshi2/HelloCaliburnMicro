using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserFlow.ViewModels.Journaling;
using UserFlow.ViewModels.LoginFlow;

namespace UserFlow.ViewModels
{
    public class MainViewModel : Caliburn.Micro.PropertyChangedBase
    {
        private const string WindowTitleDefault = "Users Manager";

        private string _windowTitle = WindowTitleDefault;

        private JournalViewModel _journalView;

        public MainViewModel()
        {
            JournalView = new JournalViewModel();
            LoginUser = new LoginUserViewModel();
        }

        public JournalViewModel JournalView
        {
            get { return _journalView; }
            set
            {
                _journalView = value;
                NotifyOfPropertyChange(() => JournalView);
            }
        }

        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

        private LoginUserViewModel _loginUser;

        public LoginUserViewModel LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; NotifyOfPropertyChange(); }
        }


    }
}
