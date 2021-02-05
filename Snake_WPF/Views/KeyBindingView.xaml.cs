using Snake_WPF.ViewModels;
using System.Windows.Input;

namespace Snake_WPF.Views
{
    /// <summary>
    /// Interaction logic for KeyBindingView.xaml
    /// </summary>
    public partial class KeyBindingView
    {
        #region Properties

        public KeyBindingViewModel ViewModel
        {
            get => DataContext as KeyBindingViewModel;
            set => DataContext = value;
        }

        #endregion Properties

        #region Constructor
        
        public KeyBindingView()
        {
            InitializeComponent();
            ViewModel = new KeyBindingViewModel(Close);
        }

        #endregion Constructor

        #region Private Methods
        
        private void KeyBindingView_OnKeyDown(object sender, KeyEventArgs e)
        {
            var key = e.Key;
            ViewModel.BindKey(key);
        }

        #endregion Private Methods
    }
}
