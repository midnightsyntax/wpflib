using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLib.Config
{
    [Serializable]
    public class WindowConfig
    {
        public WindowConfig() : this("") {}
        public WindowConfig(string name) {
            Name = name;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public string Name { get; set; }
        public double Opacity { get; set; }
        public double FontSize { get; set; }
        public WindowState WindowState { get; set; }
    }
}
