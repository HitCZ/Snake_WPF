using Snake_WPF.Logic.Extensions;
using Snake_WPF.Logic.Grid;

namespace Snake_WPF.Views
{
    /// <summary>
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen
    {
        public GameScreen()
        {
            InitializeComponent();

            MainGrid.ColumnDefinitions.AddRange(GridProvider.GetColumns(Width));
            MainGrid.RowDefinitions.AddRange(GridProvider.GetRows(Height));
        }
    }
}
