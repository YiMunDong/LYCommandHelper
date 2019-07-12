using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LYCommandHelper
{
    [Serializable]
    public class Configuration
    {
        public string Current_ProjectName;
        public string Current_VSVersion;
        public string Current_Editor_Configurator_Dir;
        public string Current_Solution_Dir;

        public bool DisableWAFMSG_WARN = false;
        public bool DisableWAFMSG_WARNING = false;
        public bool DisableWAFMSG_SETTING = false;
        public bool DisableWAFMSG_INFO = false;

        public bool CreateVSClean = false;
        public string CreateVSSelect = "msvs";

        public string BuildConfig = "profile";
        public string BuildSpec = "all";
        public bool   BuildUsingUserInput = false;
        public string BuildUserInput = "build_win_x64_vs2017_profile -p game";
    }
}
