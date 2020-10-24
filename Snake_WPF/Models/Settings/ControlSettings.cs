using System.Windows.Input;

namespace Snake_WPF.Models.Settings
{
    public class ControlSettings
    {
        #region Properties

        public Key Up { get; set; }
        public Key Down { get; set; }
        public Key Left { get; set; }
        public Key Right { get; set; }

        #endregion Properties

        #region Constructors

        public ControlSettings()
        {
        }

        public ControlSettings(Key up, Key down, Key left, Key right)
        {
            Up = up;
            Down = down;
            Left = left;
            Right = right;
        }

        #endregion Constructors
    }
}
