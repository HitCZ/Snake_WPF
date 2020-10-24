using Snake_WPF.Logic;
using System;
using System.Windows;
using System.Windows.Input;
using Snake_WPF.Views;

namespace Snake_WPF.ViewModels
{
    public class MainMenuViewModel : NotificationObject
    {
        #region Commands

        public ICommand ExitCommand
        {
            get => GetPropertyValue<ICommand>();
            set => SetPropertyValue(value);
        }

        public ICommand NewGameCommand
        {
            get => GetPropertyValue<ICommand>();
            set => SetPropertyValue(value);
        }

        public ICommand SettingsCommand
        {
            get => GetPropertyValue<ICommand>();
            set => SetPropertyValue(value);
        }

        #endregion Commands

        #region Constructor

        public MainMenuViewModel()
        {
            InitializeCommands();
        }

        #endregion Constructor

        #region Private Methods

        private void InitializeCommands()
        {
            ExitCommand = new RelayCommand(ExitCommandExecute);
            NewGameCommand = new RelayCommand(NewGameCommandExecute);
            SettingsCommand = new RelayCommand(SettingsCommandExecute);
        }

        private void SettingsCommandExecute()
        {
            var settingsView = new SettingsView();
            settingsView.ShowDialog();
        }

        private void NewGameCommandExecute()
        {
            var gameScreen = new GameScreen();
            gameScreen.Show();
        }

        private void ExitCommandExecute()
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit confirmation",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        #endregion Private Methods
    }
}
