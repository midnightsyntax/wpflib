using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfLib
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class ViewPropertyAttribute : Attribute
    {
        private string propertyName;
        private object value;

        public ViewPropertyAttribute([CallerMemberName]string viewPropCeller = "")
        {
            Trace.WriteLine(viewPropCeller);
            propertyName = viewPropCeller;
        }

        public string PropertyName
        {
            get { return propertyName; }
        }

        public dynamic Value { get { return value; } set => this.value = value; }
    }
}
