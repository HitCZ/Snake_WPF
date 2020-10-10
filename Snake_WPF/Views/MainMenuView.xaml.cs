using Snake_WPF.ViewModels;

namespace Snake_WPF.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView
    {
        #region Properties

        public MainMenuViewModel ViewModel
        {
            get => DataContext as MainMenuViewModel; 
            set => DataContext = value;
        }

        #endregion Properties

        #region Constructor

        public MainMenuView()
        {
            InitializeComponent();
            ViewModel = new MainMenuViewModel();
        }

        #endregion Constructor
    }
}
