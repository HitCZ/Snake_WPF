using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Snake_WPF.Logic;

namespace Snake_WPF.ViewModels
{
    public class SettingsViewModel : NotificationObject
    {
        #region Fields



        #endregion Fields

        #region Properties

        public object SelectedSettingsType { get; private set; }

        #endregion Properties

        #region Commands

        public ICommand SelectSettingsCommand { get; }

        #endregion Commands

        #region Constructor

        public SettingsViewModel()
        {
            //SelectSettingsCommand = new RelayCommand();
        }

        #endregion Constructor

        #region Public Methods



        #endregion Public Methods

        #region Private Methods



        #endregion Private Methods
    }
}
