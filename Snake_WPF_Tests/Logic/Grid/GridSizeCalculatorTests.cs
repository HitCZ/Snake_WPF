using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake_WPF.Logic.Exceptions;
using Snake_WPF.Logic.Grid;
using Snake_WPF.Logic.Other;
using System;

namespace Snake_WPF_Tests.Logic.Grid
{
    [TestClass]
    public class GridSizeCalculatorTests
    {
        #region Test Methods

        [TestMethod]
        public void GetMaxRowsTest()
        {
            var expected = 36;

            var actual = GridSizeCalculator.GetMaxRows(720);

            actual.Should().Be(expected);

            Action action = () => GridSizeCalculator.GetMaxRows(GlobalValues.BODY_PART_SIZE - 1);
            action.Should().Throw<InsufficientSizeException>();
        }

        [TestMethod]
        public void GetMaxColumnsTest()
        {
            var expected = 64;

            var actual = GridSizeCalculator.GetMaxColumns(1280);

            actual.Should().Be(expected);

            Action action = () => GridSizeCalculator.GetMaxColumns(GlobalValues.BODY_PART_SIZE - 1);
            action.Should().Throw<InsufficientSizeException>();
        }

        #endregion Test Methods
    }
}
