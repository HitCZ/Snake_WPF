using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using Snake_WPF.Logic;
using Snake_WPF.Logic.Enums;
using System.Windows.Input;
using Common.Commands;
using Common.WPF;
using Snake_WPF.Builders.Settings;
using Snake_WPF.Logic.Settings;
using Snake_WPF.Models.Settings;

namespace Snake_WPF.ViewModels
{
    public class SettingsViewModel : NotificationObject
    {
        #region Fields


        #endregion Fields

        #region Properties

        public Action CloseAction { get; set; }

        public SettingsViewType SelectedSettingsType
        {
            get => GetPropertyValue<SettingsViewType>();
            set => SetPropertyValue(value);
        }

        public ControlSettings ControlSettings
        {
            get => GetPropertyValue<ControlSettings>();
            set => SetPropertyValue(value);
        }

        #endregion Properties

        #region Commands

        public ICommand SelectSettingsCommand { get; }
        public ICommand BackCommand { get; }

        #endregion Commands

        #region Constructor

        public SettingsViewModel()
        {
            SelectSettingsCommand = new RelayCommand<SettingsViewType>(SelectSettingsCommandExecute);
            BackCommand = new RelayCommand(BackCommandExecute);
            SelectedSettingsType = SettingsViewType.Default;

            ControlSettings = ControlSettingsBuilder.BuildDefaultSettings();
        }

        #endregion Constructor

        #region Public Methods



        #endregion Public Methods

        #region Private Methods

        private void SelectSettingsCommandExecute(SettingsViewType parameter) => SelectedSettingsType = parameter;
        private void BackCommandExecute()
        {
            if (SelectedSettingsType == SettingsViewType.Default)
                CloseAction?.Invoke();
            else
                SelectedSettingsType = SettingsViewType.Default;
        }

        #endregion Private Methods
    }
}
