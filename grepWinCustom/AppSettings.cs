using System.Configuration;
using System.Drawing;

namespace grepWinCustom
{
    internal class AppSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue(@"\\afjhb0afasapp1\Adapter Logs\debug")]
        public string TargetFolder
        {
            get { return this["TargetFolder"].ToString(); }
            set { this["TargetFolder"] = value; }
        }
    }
}