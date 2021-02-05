using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake_WPF.Models.Settings;

namespace Snake_WPF.Logic.Settings
{
    public class SettingsManager
    {
        #region Fields

        private readonly Models.Settings.Settings settings;
        private static SettingsManager instance;

        #endregion Fields

        #region Properties

        public static SettingsManager Instance
        {
            get => instance ?? (Instance = new SettingsManager());
            set => instance = value;
        }

        public static ControlSettings ControlSettings => Instance.settings.ControlSettings;

        #endregion Properties

        #region Constructor

        private SettingsManager()
        {
            settings = Models.Settings.Settings.Instance;
        }

        #endregion Constructor

        #region Public Methods

        public void SaveSettings()
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods

        #region Private Methods

        private void LoadSettings()
        {
            throw new NotImplementedException();
        }

        #endregion Private Methods
    }
}
