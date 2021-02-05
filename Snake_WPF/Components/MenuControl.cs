using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Snake_WPF.Logic.Settings;

namespace Snake_WPF.Components
{
    public class MenuControl : StackPanel
    {
        #region Fields

        private int currentIndex;

        #endregion Fields

        #region Properties



        #endregion Properties

        #region Commands

        #endregion Commands

        #region Constructor

        public MenuControl()
        {
            KeyDown += MenuControl_KeyDown;
            GotFocus += MenuControl_GotFocus;
        }

        private void MenuControl_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            Children[currentIndex].Focus();
        }

        private void MenuControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (currentIndex <= 0)
                        currentIndex = Children.Count - 1;
                    else
                        currentIndex--;
                    break;
                case Key.Down:
                    if (currentIndex >= Children.Count - 1)
                        currentIndex = 0;
                    else
                        currentIndex++;
                    break;
            }

            Children[currentIndex].Focus();
        }

        #endregion Constructor

        #region Public Methods



        #endregion Public Methods

        #region Private Methods


        #endregion Private Methods
    }
}
