using Snake_WPF.Models.Settings;
using System.Windows;

namespace Snake_WPF.Views
{
    /// <summary>
    /// Interaction logic for ControlSettingsControl.xaml
    /// </summary>
    public partial class ControlSettingsControl
    {
        public ControlSettings Settings
        {
            get => (ControlSettings)GetValue(SettingsProperty);
            set => SetValue(SettingsProperty, value);
        }

        public static readonly DependencyProperty SettingsProperty =
            DependencyProperty.Register(nameof(Settings), typeof(ControlSettings), typeof(ControlSettingsControl));

        public ControlSettingsControl()
        {
            InitializeComponent();
        }
    }
}
