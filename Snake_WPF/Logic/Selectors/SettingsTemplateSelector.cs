using Snake_WPF.Models.Settings;
using System.Windows;
using System.Windows.Controls;

namespace Snake_WPF.Logic.Selectors
{
    public class SettingsTemplateSelector : DataTemplateSelector
    {
        #region Properties

        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate ControlSettingsTemplate { get; set; }
        public DataTemplate GraphicSettingsTemplate { get; set; }

        #endregion Properties

        #region Public Methods

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            switch (item)
            {
                case ControlSettings _:
                    return ControlSettingsTemplate;
                case GraphicSettings _:
                    return GraphicSettingsTemplate;
                default:
                    return DefaultTemplate;
            }
        }

        #endregion Public Methods
    }
}
