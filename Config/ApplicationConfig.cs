using System;
using System.Collections.Generic;

namespace WpfLib.Config
{
    [Serializable]
    public class ApplicationConfig
    {
        public List<WindowConfig> Windows { get; set; }
        public bool UpgradeRequired { get; set; }

        public ApplicationConfig()
        {
            Windows = new List<WindowConfig>();
        }
    }
}
