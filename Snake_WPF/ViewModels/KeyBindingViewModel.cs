using Common.WPF;
using System;
using System.Windows;
using System.Windows.Input;
using KeyBinding = Snake_WPF.Logic.Settings.KeyBinding;

namespace Snake_WPF.ViewModels
{
    public class KeyBindingViewModel : NotificationObject
    {
        #region Fields

        private readonly Action closeAction;
        private Func<Key, bool> isKeyBoundFunc;
        private Action<Key> unsetKeyAction;

        #endregion Fields

        #region Properties

        public KeyBinding KeyBinding
        {
            get => GetPropertyValue<KeyBinding>();
            private set => SetPropertyValue(value);
        }

        #endregion Properties

        #region Constructor

        public KeyBindingViewModel(Action close)
        {
            closeAction = close ?? throw new ArgumentNullException(nameof(close));
        }

        #endregion Constructor

        #region Public Methods

        public void Initialize(KeyBinding keyBinding, Func<Key, bool> isKeyAlreadyBoundFunc, Action<Key> unsetKey)
        {
            isKeyBoundFunc = isKeyAlreadyBoundFunc ?? throw new ArgumentNullException(nameof(isKeyAlreadyBoundFunc));
            unsetKeyAction = unsetKey ?? throw new ArgumentNullException(nameof(unsetKey));
            KeyBinding = keyBinding ?? throw new ArgumentException(nameof(keyBinding));
        }

        public void BindKey(Key key)
        {
            if (!isKeyBoundFunc(key))
                KeyBinding.BoundKey = key;

            var result = MessageBox.Show($"Key '{key}' is already bound. Do you want to unset the original binding?",
                "Key already bound", MessageBoxButton.OKCancel);

            if (result != MessageBoxResult.OK)
                return;

            unsetKeyAction(key);
            KeyBinding.BoundKey = key;
            closeAction();
        }

        #endregion Public Methods
    }
}
