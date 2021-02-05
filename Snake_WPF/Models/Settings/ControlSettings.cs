using System.Collections.ObjectModel;
using System.Windows.Input;
using Snake_WPF.Logic.Settings;
using KeyBinding = Snake_WPF.Logic.Settings.KeyBinding;

namespace Snake_WPF.Models.Settings
{
    public class ControlSettings
    {
        #region Properties

        public ObservableCollection<KeyBinding> SettingsItems { get; set; }

        #endregion Properties

        #region Constructors

        public ControlSettings()
        {
        }

        #endregion Constructors
    }
}
