using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Common.Extensions;
using Snake_WPF.Models.Settings;
using KeyBinding = Snake_WPF.Logic.Settings.KeyBinding;

namespace Snake_WPF.Logic.Extensions
{
    public static class ControlSettingsExtensions
    {
        #region Fields



        #endregion Fields

        #region Properties



        #endregion Properties

        #region Constructor



        #endregion Constructor

        #region Public Methods

        public static List<Key> GetBoundKeys(this ControlSettings settings)
        {
            if (settings is null)
                throw new ArgumentNullException(nameof(settings));

            var keys = settings.SettingsItems?.Select(si => si.BoundKey).NotNull().Cast<Key>().ToList();
            return keys;
        }

        public static bool IsKeyBound(this ControlSettings settings, Key key)
        {
            var result = GetBoundKeys(settings).Contains(key);
            return result;
        }

        public static KeyBinding GetBindingByKey(this ControlSettings settings, Key key)
        {
            if (settings is null)
                throw new ArgumentNullException(nameof(settings));

            var keyBinding = settings.SettingsItems?.SingleOrDefault(binding => binding.BoundKey == key);
            return keyBinding;
        }

        public static void UnsetKey(this ControlSettings settings, Key key)
        {
            var binding = settings.GetBindingByKey(key);

            if (binding is null)
                return;

            binding.BoundKey = null;
        }

        #endregion Public Methods

        #region Private Methods



        #endregion Private Methods
    }
}
