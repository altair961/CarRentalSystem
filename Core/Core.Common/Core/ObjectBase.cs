using System.Collections.Generic;
using System.ComponentModel;

namespace Core.Common.Core
{
    public class ObjectBase : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler _PropertyChanged;

        List<PropertyChangedEventHandler> _PropertyChangedSubscribers
            = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (!_PropertyChangedSubscribers.Contains(value))
                {
                    _PropertyChanged += value;
                    _PropertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                _PropertyChanged -= value;
                _PropertyChangedSubscribers.Remove(value);
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName, true);
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            if (_PropertyChanged != null)
                _PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            if (makeDirty)
                _IsDirty = true;
        }

        bool _IsDirty;

        public bool IsDirty
        {
            get
            {
                return _IsDirty;
            }
        }
    }
}
