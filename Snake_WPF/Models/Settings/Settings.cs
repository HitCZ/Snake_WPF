﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake_WPF.Logic;

namespace Snake_WPF.Models.Settings
{
    public class Settings
    {
        #region Fields

        private static Settings instance;

        #endregion Fields

        #region Properties

        public ControlSettings ControlSettings { get; set; }

        public static Settings Instance => instance ?? (instance = new Settings());

        #endregion Properties

        #region Constructor



        #endregion Constructor

        #region Public Methods



        #endregion Public Methods

        #region Private Methods



        #endregion Private Methods
    }
}
