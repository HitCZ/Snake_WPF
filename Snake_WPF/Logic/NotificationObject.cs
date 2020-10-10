﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Snake_WPF.Annotations;
using Snake_WPF.Logic.Extensions;

namespace Snake_WPF.Logic
{
    public class NotificationObject : INotifyPropertyChanged
    {
        #region Fields

        private readonly Dictionary<string, object> propertiesCache = new Dictionary<string, object>();

        #endregion Fields

        public T GetPropertyValue<T>([CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
                throw new ArgumentNullException(nameof(propertyName));
            if (propertiesCache.TryGetValue(propertyName, out var propertyValue))
                return (T)propertyValue;

            return default;
        }

        public void SetPropertyValue<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
                throw new ArgumentNullException(nameof(propertyName));
            propertiesCache[propertyName] = value;
            OnPropertyChanged(propertyName);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged
    }
}
