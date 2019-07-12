using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Xml.Serialization;


namespace LYCommandHelper
{
    public partial class MainForm : Form
    {
        #region Member Variable

        private FileSystemWatcher FileWatcher_UserOption;
        private Configuration Config;
        private Process WAFProcess;

        private Color OriginalTextColor;
        private Font OriginalTextFont;

        #endregion

        #region External Function(Win32)

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);        
        [DllImport("kernel32.dll")]
        internal static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        internal static extern bool FreeConsole();
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);

        delegate Boolean ConsoleCtrlDelegate(uint CtrlType);
        internal const int CTRL_C_EVENT = 0;

        #endregion

        #region Build_Paks_PC.bat        

        static public string Build_Paks_PC_BAT = @"
@echo off

setlocal enabledelayedexpansion

set ORIGINALDIRECTORY=%cd%
set MYBATCHFILEDIRECTORY=%~dp0
cd ""%MYBATCHFILEDIRECTORY%""

call ""%MYBATCHFILEDIRECTORY%\\DetermineRCandAP.bat"" SILENT

IF ERRORLEVEL 1 (
EXIT /b 1
)
ECHO Detected binary folder at %MYBATCHFILEDIRECTORY%%BINFOLDER%

echo [BUILDPAK]----- Processing Assets Using Asset Processor Batch ----
.\\%BINFOLDER%\\AssetProcessorBatch.exe /gamefolder=${ProjectName} /platforms=${Platforms}
IF ERRORLEVEL 1 GOTO AssetProcessingFailed

echo [BUILDPAK]----- Creating Packages ----
.\\%BINFOLDER%\\rc\\rc.exe /job=%BINFOLDER%\\rc\\RCJob_Generic_MakePaks.xml /p=${Platforms} /game=${ProjectName}
IF ERRORLEVEL 1 GOTO RCFailed

echo [BUILDPAK]----- Done -----
cd ""%ORIGINALDIRECTORY%""
exit /b 0

:RCFailed
echo [BUILDPAK]----- RC PAK failed ----
cd ""%ORIGINALDIRECTORY%""
exit /b 1

:AssetProcessingFailed
echo [BUILDPAK]----- ASSET PROCESSING FAILED ----
cd ""%ORIGINALDIRECTORY%""
exit /b 1
";

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            FileInfo RootFileInfo = new FileInfo(Directory.GetCurrentDirectory() + "\\engineroot.txt");
            if(RootFileInfo.Exists==false)
            {
                MessageBox.Show("This progame is must run in the \"dev\" directory.");
                Close();
                return;
            }

            OriginalTextFont = OutputBox.SelectionFont;
            OriginalTextColor = OutputBox.SelectionColor;

            FileWatcher_UserOption = new FileSystemWatcher();
            FileWatcher_UserOption.Path = Directory.GetCurrentDirectory() + "\\_WAF_";
            FileWatcher_UserOption.Filter = "user_settings.options";
            FileWatcher_UserOption.Changed += new FileSystemEventHandler(FileWatcher_UserOption_Changed);
            FileWatcher_UserOption.EnableRaisingEvents = true;
            FileWatcher_UserOption.IncludeSubdirectories = false;

            LoadConfig();
            Update_Useroption();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        #region Load/Save_Config        

        private void LoadConfig()
        {
            Config = new Configuration();
            try
            {
                using (FileStream fs = new FileStream("LYCommandHelper.cfg", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xs = new XmlSerializer(Config.GetType());
                    Config = (Configuration)xs.Deserialize(fs);                    
                }
            }
            catch (Exception)
            {
            }

            cbMSG_WARN.Checked = Config.DisableWAFMSG_WARN;
            cbMSG_WARNING.Checked = Config.DisableWAFMSG_WARNING;
            cbMSG_SETTINGS.Checked = Config.DisableWAFMSG_SETTING;
            cbMSG_INFO.Checked = Config.DisableWAFMSG_INFO;
            Config.Current_Solution_Dir = Directory.GetCurrentDirectory() + "\\Solutions";
        }

        private void SaveConfig()
        {
            if(Config!=null)
            {
                try
                {
                    using (FileStream fs = new FileStream("LYCommandHelper.cfg", FileMode.Create, FileAccess.Write))
                    {
                        XmlSerializer xs = new XmlSerializer(Config.GetType());
                        xs.Serialize(fs, Config);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        #endregion

        private void FileWatcher_UserOption_Changed(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(100);
            Action FileChange = () => Update_Useroption();
            this.Invoke(FileChange);
        }

        private void Update_Useroption()
        {
            Config.Current_ProjectName = Parse_UserOption("Game Projects", "enabled_game_projects");
            {
                groupBox_ProjectInfo.Text = "Project : [";
                groupBox_ProjectInfo.Text += string.IsNullOrEmpty(Config.Current_ProjectName) ? "unknown" : Config.Current_ProjectName;
                groupBox_ProjectInfo.Text += "]";

            }

            string VSVersion = Parse_UserOption("Visual Studio Project Generator", "msvs_version");
            {
                Label_VSVersion.Text = "Visual Studio Version : ";

                if (!string.IsNullOrEmpty(VSVersion))
                {
                    int ver = Convert.ToInt32(VSVersion);

                    switch (ver)
                    {
                        case 14:
                            Config.Current_VSVersion = "2015";
                            Label_VSVersion.Text += Config.Current_VSVersion;
                            Config.Current_Editor_Configurator_Dir = Directory.GetCurrentDirectory() + "\\Bin64vc140";
                            break;

                        case 15:
                            Config.Current_VSVersion = "2017";
                            Label_VSVersion.Text += Config.Current_VSVersion;
                            Config.Current_Editor_Configurator_Dir = Directory.GetCurrentDirectory() + "\\Bin64vc141";
                            break;

                        default:
                            Label_VSVersion.Text += "unknown";
                            break;
                    }
                }
                else
                    Label_VSVersion.Text += "unknown ]";
            }
        }        

        private string Parse_UserOption(string Section, string Key)
        {
            StringBuilder strValue = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", strValue, 255, @"_WAF_\\user_settings.options");
            return strValue.ToString();
        }      

        private void LaunchLumberyardTool(string filename)
        {
            if (!string.IsNullOrEmpty(Config.Current_Editor_Configurator_Dir))
            {
                string Fullpath = Config.Current_Editor_Configurator_Dir + filename;

                if (File.Exists(Fullpath))
                    Process.Start(Fullpath);
                else
                {
                    string msg = "Folder or file does not exist."
                        + Environment.NewLine
                        + Fullpath;

                    MessageBox.Show(msg, "warning");
                }
            }
        }

        private void DisableControl(int ProgressBarValue)
        {
            groupBox_ProjectInfo.Enabled = false;
            groupBox_Lumberyard.Enabled = false;

            Label_Progress.Text = "Processing..";

            ProgressBar.Enabled = true;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            ProgressBar.Value = ProgressBarValue;

            btnSaveOutput.Enabled = false;
            btnBreak.Enabled = true;
        }

        private void EnableControl()
        {
            groupBox_ProjectInfo.Enabled = true;
            groupBox_Lumberyard.Enabled = true;

            Label_Progress.Text = "State : Idle";

            ProgressBar.Enabled = false;
            ProgressBar.Minimum = 0;
            ProgressBar.Value = ProgressBar.Maximum;

            btnSaveOutput.Enabled = true;
            btnBreak.Enabled = false;
        }

        private void ReceiveMessage(string Message)
        {
            OutputBox.SelectionColor = OriginalTextColor;
            OutputBox.SelectionFont = OriginalTextFont;

            if (!string.IsNullOrEmpty(Message))
            {
                bool bWAFMessage = false;

                if (Message.IndexOf("[WAF]") >= 0)
                {
                    bWAFMessage = true;
                    OutputBox.SelectionFont = new Font(OriginalTextFont, FontStyle.Bold);
                    OutputBox.SelectionColor = Color.Green;
                }

                if (Message.IndexOf("[WARN]", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    bWAFMessage = true;
                    if (cbMSG_WARN.Checked)
                        return;

                    OutputBox.SelectionColor = Color.Orange;
                }

                if (Message.IndexOf("[SETTINGS]") >= 0)
                {
                    bWAFMessage = true;
                    if (cbMSG_SETTINGS.Checked)
                        return;

                    OutputBox.SelectionColor = Color.Pink;
                }

                if (Message.IndexOf("[WARNING]", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    bWAFMessage = true;
                    if (cbMSG_WARNING.Checked)
                        return;

                    OutputBox.SelectionColor = Color.OrangeRed;
                }

                if (Message.IndexOf("[ERROR]") >= 0)
                {
                    bWAFMessage = true;
                    OutputBox.SelectionFont = new Font(OriginalTextFont, FontStyle.Bold);
                    OutputBox.SelectionColor = Color.Red;
                }

                if (Message.IndexOf("[INFO]") >= 0)
                {
                    bWAFMessage = true;
                    if (cbMSG_INFO.Checked)
                        return;

                    OutputBox.SelectionColor = Color.SkyBlue;
                }

                if (Message.IndexOf("[BUILDPAK]") >= 0)
                {
                    bWAFMessage = true;

                    Message = Environment.NewLine + Message.Replace("[BUILDPAK]", "");

                    OutputBox.SelectionFont = new Font(OriginalTextFont, FontStyle.Bold);
                    OutputBox.SelectionColor = Color.Green;
                }

                if (bWAFMessage == false)
                {
                    ProgressMessage(Message);
                }                

                OutputBox.AppendText(Message + Environment.NewLine);
            }            
        }

        private bool ProgressMessage(string Message)
        {
            int LastIndex = Message.IndexOf(']');
            if (Message[0]=='[' && LastIndex > 0)
            {
                string strTAG = Message.Substring(1, LastIndex-1);
                strTAG = strTAG.Replace(" ", "");

                int midIndex = strTAG.IndexOf('/');
                if(midIndex>0)
                {
                    string strNow = strTAG.Substring(0, midIndex);
                    string strTotal = strTAG.Substring(midIndex + 1, strTAG.Length - midIndex - 1);

                    int nNow = -1;
                    int nTotal = -1;
                    if(int.TryParse(strNow, out nNow)==true && int.TryParse(strTotal, out nTotal))
                    {
                        ProgressBar.Minimum = 0;
                        ProgressBar.Maximum = nTotal;
                        ProgressBar.Value = nNow;

                        Label_Progress.Text = string.Format("[ {0} / {1} ]", nNow, nTotal);
                        
                        return true;
                    }
                }                
            }
            return false;
        }

        private void AppMessage(string Message, int BeforeEmptyLine, int AfterEmptyLine, Color color, bool bold)
        {
            for (int i = 0; i < BeforeEmptyLine; ++i) OutputBox.AppendText(Environment.NewLine);

            {
                Color OldColor = OutputBox.SelectionColor;
                Font OldFont = OutputBox.SelectionFont;

                OutputBox.SelectionColor = color;

                if (bold)
                    OutputBox.SelectionFont = new Font(OldFont, FontStyle.Bold);

                OutputBox.AppendText(Message + Environment.NewLine);

                OutputBox.SelectionColor = OldColor;
                OutputBox.SelectionFont = OldFont;
            }            

            for (int i = 0; i < AfterEmptyLine; ++i) OutputBox.AppendText(Environment.NewLine);
        }

        private void Command(string FileName, string Arguments)
        {
            if (WAFProcess != null)
                WAFProcess.Dispose();

            WAFProcess = new Process();

            WAFProcess.StartInfo.FileName = FileName;
            WAFProcess.StartInfo.Arguments = Arguments;

            WAFProcess.StartInfo.CreateNoWindow = true;
            WAFProcess.StartInfo.UseShellExecute = false;
            WAFProcess.EnableRaisingEvents = true;

            WAFProcess.StartInfo.RedirectStandardError = true;
            WAFProcess.StartInfo.RedirectStandardOutput = true;
            WAFProcess.StartInfo.RedirectStandardInput = true;

            WAFProcess.OutputDataReceived += (s, e) => {
                Action action = () => ReceiveMessage(e.Data);
                this.Invoke(action);
            };

            WAFProcess.ErrorDataReceived += (s, e) =>
            {
                Action action = () => ReceiveMessage(e.Data);
                this.Invoke(action);
            };

            WAFProcess.Exited += (s, e) =>
            {
                Action Final = () =>
                {
                    EnableControl();
                    AppMessage("=========> Complete!!", 1, 1, Color.Yellow, true);
                };
                this.Invoke(Final);
            };

            WAFProcess.Start();
            WAFProcess.BeginOutputReadLine();
            WAFProcess.BeginErrorReadLine();
        }

        #region ButtonClick

        private void Configure_Click(object sender, EventArgs e)
        {
            DisableControl(50);
            Command("lmbr_waf.bat", "configure");
        }

        private void btnVSSolution_Click(object sender, EventArgs e)
        {
            VSSolution dlg = new VSSolution();
            dlg.Config = Config;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DisableControl(50);
                Command("lmbr_waf.bat", dlg.CommandOption);
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            BuildOption dlg = new BuildOption();
            dlg.Config = Config;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DisableControl(50);
                if (Config.BuildUsingUserInput)
                    Command("lmbr_waf.bat", Config.BuildUserInput);
                else
                    Command("lmbr_waf.bat", dlg.CommandOption);
            }
        }

        private void btnShowWAFDialog_Click(object sender, EventArgs e)
        {
            DisableControl(50);
            Command("lmbr_waf.bat", "show_option_dialog");
        }

        private void btnLaunchEditor_Click(object sender, EventArgs e)
        {
            LaunchLumberyardTool("\\Editor.exe");
        }

        private void btnConfigurator_Click(object sender, EventArgs e)
        {
            LaunchLumberyardTool("\\ProjectConfigurator.exe");
        }

        private void btnAssistant_Click(object sender, EventArgs e)
        {
            string Fullpath = Directory.GetCurrentDirectory();
            Fullpath += @"\Tools\LmbrSetup\Win\SetupAssistant.exe";
            Process.Start(Fullpath);
        }

        private void btnBuildProjectPak_Click(object sender, EventArgs e)
        {
            string TmpFile = Directory.GetCurrentDirectory() + "\\_TmpBuildPak_.bat";
            string Batch = Build_Paks_PC_BAT.Replace("${ProjectName}", Config.Current_ProjectName);
            Batch = Batch.Replace("${Platforms}", "pc");

            System.IO.File.WriteAllText(TmpFile, Batch, Encoding.Default);

            DisableControl(50);
            Command("_TmpBuildPak_.bat", "");
        }

        private void btnBuildShaderPak_Click(object sender, EventArgs e)
        {
            DisableControl(50);
            Command("lmbr_pak_shaders.bat", Config.Current_ProjectName + " D3D11 pc");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            if (SaveRTF.ShowDialog() == DialogResult.OK)
            {
                OutputBox.SaveFile(SaveRTF.FileName);
            }
        }


        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (AttachConsole((uint)WAFProcess.Id))
            {
                SetConsoleCtrlHandler(null, true);
                if (GenerateConsoleCtrlEvent(CTRL_C_EVENT, 0))
                {
                    WAFProcess.Kill();
                }
                FreeConsole();
                SetConsoleCtrlHandler(null, false);
            }
        }

        #endregion

        #region CheckboxClick

        private void cbWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            OutputBox.WordWrap = cbWordWrap.Checked;
        }

        private void cbMSG_WARN_CheckedChanged(object sender, EventArgs e)
        {
            Config.DisableWAFMSG_WARN = cbMSG_WARN.Checked;
        }

        private void cbMSG_WARNING_CheckedChanged(object sender, EventArgs e)
        {
            Config.DisableWAFMSG_WARNING = cbMSG_WARNING.Checked;
        }

        private void cbMSG_SETTINGS_CheckedChanged(object sender, EventArgs e)
        {
            Config.DisableWAFMSG_SETTING = cbMSG_SETTINGS.Checked;
        }

        private void cbMSG_INFO_CheckedChanged(object sender, EventArgs e)
        {
            Config.DisableWAFMSG_INFO = cbMSG_INFO.Checked;
        }

        #endregion

        #region LinkClick

        private void linkLumberyard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://aws.amazon.com/lumberyard");
        }

        private void linkLYGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/aws/lumberyard");
        }

        private void linkUserGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/awsdocs/amazon-lumberyard-user-guide");
        }        

        private void linkSourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/YiMunDong/LYCommandHelper");
        }

        #endregion
    }
}
