using Snake_WPF.Logic.Exceptions;
using Snake_WPF.Logic.Other;
using System;

namespace Snake_WPF.Logic.Grid
{
    public static class GridSizeCalculator
    {
        #region Public Methods

        /// <summary>
        /// Based on width & height calculates how many rows can fit in horizontally.
        /// </summary>
        /// <returns>Maximum number of rows</returns>
        public static double GetMaxRows(double height)
        {
            if (height <= GlobalValues.BODY_PART_SIZE)
                throw new InsufficientSizeException(nameof(height), GlobalValues.BODY_PART_SIZE);
            var roundedRows = GetRoundedResult(height);

            return roundedRows;
        }

        /// <summary>
        /// Based on width & height calculates how many rows can fit in horizontally.
        /// </summary>
        /// <returns>Maximum number of columns</returns>
        public static double GetMaxColumns(double width)
        {
            if (width <= GlobalValues.BODY_PART_SIZE)
                throw new InsufficientSizeException(nameof(width), GlobalValues.BODY_PART_SIZE);
            var roundedColumns = GetRoundedResult(width);

            return roundedColumns;
        }

        #endregion Public Methods

        #region Private Methods

        private static double GetRoundedResult(double size)
        {
            var rows = size / GlobalValues.BODY_PART_SIZE;
            var ceilRows = Math.Ceiling(rows);

            return ceilRows;
        }

        #endregion Private Methods
    }
}
