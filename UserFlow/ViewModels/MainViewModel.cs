using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserFlow.ViewModels
{
    public class MainViewModel : Caliburn.Micro.PropertyChangedBase
    {
        private const string WindowTitleDefault = "Users Manager";

        private string _windowTitle = WindowTitleDefault;

        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

    }
}
