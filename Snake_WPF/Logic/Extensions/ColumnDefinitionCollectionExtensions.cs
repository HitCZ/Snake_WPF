using System.Collections.Generic;
using System.Windows.Controls;

namespace Snake_WPF.Logic.Extensions
{
    public static class ColumnDefinitionCollectionExtensions
    {
        #region Public Methods

        public static void AddRange(this ColumnDefinitionCollection collection, IEnumerable<ColumnDefinition> columns)
        {
            foreach (var column in columns)
                collection.Add(column);
        }

        #endregion Public Methods
    }
}
