using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace WpfLib.ViewModel
{
    public abstract class ViewModelBase : Control, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected float GetProperty([CallerMemberName]string property = "")
        {
            return GetType().GetProperty(property).GetCustomAttribute<ViewPropertyAttribute>().Value;
        }
        protected void SetProperty<T>(ref T prop, dynamic value, [CallerMemberName]string property = "")
        {
            prop = value;
            RaisePropertyChanged(property);
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        protected void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}