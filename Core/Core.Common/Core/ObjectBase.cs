using Core.Common.Extensions;
using Core.Common.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Core.Common.Core
{
    public class ObjectBase : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler propertyChanged;

        private List<PropertyChangedEventHandler> propertyChangedSubscribers
            = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (!propertyChangedSubscribers.Contains(value))
                {
                    propertyChanged += value;
                    propertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                propertyChanged -= value;
                propertyChangedSubscribers.Remove(value);
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName, true);
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            if (makeDirty)
                _IsDirty = true;
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            string propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }

        bool _IsDirty;

        public bool IsDirty
        {
            get
            {
                return _IsDirty;
            }
        }
        protected List<ObjectBase> GetDirtyObjects()
        {
            List<ObjectBase> dirtyObjects = new List<ObjectBase>();
            List<ObjectBase> visited = new List<ObjectBase>();

            Action<ObjectBase> walk = null;

            walk = (o) =>
            {
                if (o != null && !visited.Contains(o))
                {
                    visited.Add(o);

                    if (o.IsDirty)
                        dirtyObjects.Add(o);

                    bool exitWalk = false;

                    if (!exitWalk)
                    {
                        PropertyInfo[] properties = o.GetBrowsableProperties();
                        foreach (PropertyInfo property in properties)
                        {

                        }
                    }
                }
            }

            return dirtyObjects;
        }
    }
}
