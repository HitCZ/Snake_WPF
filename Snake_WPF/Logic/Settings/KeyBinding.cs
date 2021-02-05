using System.Windows.Input;
using Common.WPF;

namespace Snake_WPF.Logic.Settings
{
    public class KeyBinding : NotificationObject
    {
        #region Properties

        public string Caption { get; }

        public Key? BoundKey
        {
            get => GetPropertyValue<Key?>();
            set => SetPropertyValue(value);
        }

        #endregion Properties

        #region Constructor

        public KeyBinding(string caption, Key? boundKey = null)
        {
            Caption = caption;
            BoundKey = boundKey;
        }

        #endregion Constructor
    }
}
