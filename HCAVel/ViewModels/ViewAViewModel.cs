using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HCAVel.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        #region --- Properties ---
        private string _firstName = "Bob";
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetProperty(ref _firstName, value);
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetProperty(ref _lastName, value);
            }
        }

        private string _lastUpdated;
        public string LastUpdated
        {
            get { return _lastUpdated; }
            set
            {
                SetProperty(ref _lastUpdated, value);
            }
        }
        #endregion

        #region --- Commands ---
        public DelegateCommand UpdateCommand { get; set; }

        public ViewAViewModel()
        {
            UpdateCommand = new DelegateCommand(Execute, CanExecute)
                .ObservesProperty(() => FirstName)
                .ObservesProperty(() => LastName); ;
        }
        #endregion

        private bool CanExecute()
        {
            bool returnValue = !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
            return returnValue;
        }

        private void Execute()
        {
            _lastUpdated = DateTime.Now.ToShortDateString();
        }

            //get { return _firstName; }

            //set
            //{
            //    _firstName = value;
            //    OnPropertyChanged();
            //}
        }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //    {
    //        // Use handler to prevent the possibility of PropertyChanged going null after if null test
    //        var handler = PropertyChanged;
    //        if (handler != null)
    //        {
    //            handler(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
 }
