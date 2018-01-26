using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLib.Config;

namespace WpfLib.Windows
{
    sealed class WindowSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public ApplicationConfig Config
        {
            get
            {
                if (this["Config"] == null) this["Config"] = new ApplicationConfig();
                return ((ApplicationConfig)this["Config"]);
            }
            set
            {
                this["Config"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public List<WindowConfig> Windows
        {
            get
            {
                if (this["Windows"] == null) this["Windows"] = new List<WindowConfig>();
                return (List<WindowConfig>)this["Windows"];
            }

            set
            {
                this["Windows"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool UpgradeRequired
        {
            get
            {
                return (bool)this["UpgradeRequired"];
            }

            set
            {
                this["UpgradeRequired"] = value;
            }
        }
        public WindowSettings()
        {

        }
    }
}
