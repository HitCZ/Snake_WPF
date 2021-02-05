using Snake_WPF.ViewModels;

namespace Snake_WPF.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView
    {
        public SettingsViewModel ViewModel
        {
            get => DataContext as SettingsViewModel; 
            set => DataContext = value;
        }

        public SettingsView()
        {
            InitializeComponent();
            ViewModel = new SettingsViewModel
            {
                CloseAction = Close
            };
        }
    }
}
