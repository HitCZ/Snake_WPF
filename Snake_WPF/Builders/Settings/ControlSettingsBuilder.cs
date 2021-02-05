using Snake_WPF.Logic.Settings;
using Snake_WPF.Models.Settings;
using System.Collections.ObjectModel;
using System.Windows.Input;
using KeyBinding = Snake_WPF.Logic.Settings.KeyBinding;

namespace Snake_WPF.Builders.Settings
{
    public static class ControlSettingsBuilder
    {
        #region Public Methods

        public static ControlSettings BuildDefaultSettings()
        {
            return new ControlSettings
            {
                SettingsItems = new ObservableCollection<KeyBinding>
                {
                    new KeyBinding("Up", Key.W),
                    new KeyBinding("Down", Key.S),
                }
            };
        }

        #endregion Public Methods
    }
}
