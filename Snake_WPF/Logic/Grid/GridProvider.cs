using System.Collections.Generic;
using System.Windows.Controls;

namespace Snake_WPF.Logic.Grid
{
    public static class GridProvider
    {
        #region Public Methods

        public static IEnumerable<RowDefinition> GetRows(double height)
        {
            var rows = new List<RowDefinition>();
            
            for (var i = 0; i < GridSizeCalculator.GetMaxColumns(height); i++)
            {
                var row = new RowDefinition();
                rows.Add(row);
            }

            return rows;
        }

        public static IEnumerable<ColumnDefinition> GetColumns(double width)
        {
            var columns = new List<ColumnDefinition>();

            for (var i = 0; i < GridSizeCalculator.GetMaxRows(width); i++)
            {
                var column = new ColumnDefinition();
                columns.Add(column);
            }

            return columns;
        }

        #endregion Public Methods
    }
}
