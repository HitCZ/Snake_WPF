using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Snake_WPF.Logic.Extensions
{
    public static class RowDefinitionCollectionExtensions
    {

        #region Public Methods

        public static void AddRange(this RowDefinitionCollection collection, IEnumerable<RowDefinition> rows)
        {
            foreach (var row in rows)
                collection.Add(row);
        }

        #endregion Public Methods
    }
}
