using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserFlow.ViewModels.LoginFlow
{
    public class LoginUserViewModel : PropertyChangedBase
    {
        public LoginUserViewModel()
        {

        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; NotifyOfPropertyChange(); }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; NotifyOfPropertyChange(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; NotifyOfPropertyChange(); }
        }

        private bool showpassword;

        public bool CanResetName
        {
            get { return showpassword; }
            set { showpassword = value; NotifyOfPropertyChange(); }
        }

        private string fullname;

        public string FullName
        {
            get { return fullname; }
            set { fullname = value; NotifyOfPropertyChange(); }
        }


        public void ResetName()
        {
            FullName = $"{Username} - {Email}";
        }

    }
}
