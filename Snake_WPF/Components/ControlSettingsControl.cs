using Common.Commands;
using Snake_WPF.Logic.Settings;
using Snake_WPF.Models.Settings;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Snake_WPF.Logic.Extensions;
using Snake_WPF.Views;
using KeyBinding = Snake_WPF.Logic.Settings.KeyBinding;

namespace Snake_WPF.Components
{
    public class ControlSettingsControl : Control
    {
        #region Properties

        public ControlSettings Settings
        {
            get => (ControlSettings)GetValue(SettingsProperty);
            set => SetValue(SettingsProperty, value);
        }

        public static readonly DependencyProperty SettingsProperty =
            DependencyProperty.Register(nameof(Settings), typeof(ControlSettings), typeof(ControlSettingsControl));

        #endregion Properties

        #region Commands

        public ICommand OpenBindingDialogCommand { get; }

        #endregion Commands

        #region Constructor

        static ControlSettingsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlSettingsControl),
                new FrameworkPropertyMetadata(typeof(ControlSettingsControl)));
        }

        public ControlSettingsControl()
        {
            OpenBindingDialogCommand = new RelayCommand<KeyBinding>(OpenBindingDialogCommandExecute);
        }

        #endregion Constructor

        #region Private Methods

        private void OpenBindingDialogCommandExecute(KeyBinding item)
        {
            var view = new KeyBindingView();
            view.ViewModel.Initialize(item, Settings.IsKeyBound, Settings.UnsetKey);
            view.ShowDialog();
        }

        #endregion Private Methods
    }
}
