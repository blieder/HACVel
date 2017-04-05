using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCAVelModels;

namespace HCAVel.ViewModels 
{
    public class LoginViewModel : BindableBase
    {
        #region --- Properties ---
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetProperty(ref _userName, value);
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
            }
        }

        private string _selectedServer;
        public string SelectedServer
        {
            get { return _selectedServer.ServerName; }
            set
            {
                SetProperty(ref _selectedServer, value);
            }

        }

        public List<HCAVelModels.HACVelServer> Servers
        {
            get
            {
                List<HCAVelModels.HACVelServer> returnValue = new HCAVelModels.HACVelServer().GetServers();
                return returnValue;
            }
        }

        #endregion

        #region --- Commands ---
        private bool CanExecuteLogin()
        {
            bool returnValue = 
                !string.IsNullOrWhiteSpace(_password) 
                && !string.IsNullOrWhiteSpace(_userName);
            return returnValue;
        }

        private void ExecuteLogin()
        {
            throw new NotImplementedException("LoginViewModel");
        }

        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(ExecuteLogin, CanExecuteLogin)
                .ObservesProperty(() => UserName)
                .ObservesProperty(() => Password);
        }
        #endregion
    }

}
