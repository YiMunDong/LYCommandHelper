namespace LYCommandHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Label_Progress = new System.Windows.Forms.Label();
            this.groupBox_ProjectInfo = new System.Windows.Forms.GroupBox();
            this.btnBuildProjectPak = new System.Windows.Forms.Button();
            this.btnBuildShaderPak = new System.Windows.Forms.Button();
            this.btnVSSolution = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.Label_VSVersion = new System.Windows.Forms.Label();
            this.btnShowWAFDialog = new System.Windows.Forms.Button();
            this.btnConfigurator = new System.Windows.Forms.Button();
            this.btnAssistant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMSG_WARNING = new System.Windows.Forms.CheckBox();
            this.cbMSG_INFO = new System.Windows.Forms.CheckBox();
            this.cbMSG_SETTINGS = new System.Windows.Forms.CheckBox();
            this.cbMSG_WARN = new System.Windows.Forms.CheckBox();
            this.btnLaunchEditor = new System.Windows.Forms.Button();
            this.groupBox_Lumberyard = new System.Windows.Forms.GroupBox();
            this.btnBreak = new System.Windows.Forms.Button();
            this.cbWordWrap = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.SaveRTF = new System.Windows.Forms.SaveFileDialog();
            this.linkLumberyard = new System.Windows.Forms.LinkLabel();
            this.linkLYGithub = new System.Windows.Forms.LinkLabel();
            this.linkUserGuide = new System.Windows.Forms.LinkLabel();
            this.linkSourceCode = new System.Windows.Forms.LinkLabel();
            this.groupBox_ProjectInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Lumberyard.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.BackColor = System.Drawing.Color.Black;
            this.OutputBox.ForeColor = System.Drawing.Color.White;
            this.OutputBox.HideSelection = false;
            this.OutputBox.Location = new System.Drawing.Point(12, 203);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(762, 282);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            this.OutputBox.WordWrap = false;
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(6, 36);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(259, 23);
            this.btnConfigure.TabIndex = 2;
            this.btnConfigure.Text = "Run Project Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.Configure_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Enabled = false;
            this.ProgressBar.Location = new System.Drawing.Point(117, 526);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(655, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // Label_Progress
            // 
            this.Label_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Progress.Location = new System.Drawing.Point(14, 526);
            this.Label_Progress.Name = "Label_Progress";
            this.Label_Progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Progress.Size = new System.Drawing.Size(97, 23);
            this.Label_Progress.TabIndex = 4;
            this.Label_Progress.Text = "State : Idle";
            this.Label_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_ProjectInfo
            // 
            this.groupBox_ProjectInfo.Controls.Add(this.btnBuildProjectPak);
            this.groupBox_ProjectInfo.Controls.Add(this.btnBuildShaderPak);
            this.groupBox_ProjectInfo.Controls.Add(this.btnVSSolution);
            this.groupBox_ProjectInfo.Controls.Add(this.btnBuild);
            this.groupBox_ProjectInfo.Controls.Add(this.Label_VSVersion);
            this.groupBox_ProjectInfo.Controls.Add(this.btnConfigure);
            this.groupBox_ProjectInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ProjectInfo.Name = "groupBox_ProjectInfo";
            this.groupBox_ProjectInfo.Size = new System.Drawing.Size(271, 185);
            this.groupBox_ProjectInfo.TabIndex = 5;
            this.groupBox_ProjectInfo.TabStop = false;
            this.groupBox_ProjectInfo.Text = "Current Project :";
            // 
            // btnBuildProjectPak
            // 
            this.btnBuildProjectPak.Location = new System.Drawing.Point(6, 123);
            this.btnBuildProjectPak.Name = "btnBuildProjectPak";
            this.btnBuildProjectPak.Size = new System.Drawing.Size(259, 23);
            this.btnBuildProjectPak.TabIndex = 15;
            this.btnBuildProjectPak.Text = "Build Release Project Paks (PC)";
            this.btnBuildProjectPak.UseVisualStyleBackColor = true;
            this.btnBuildProjectPak.Click += new System.EventHandler(this.btnBuildProjectPak_Click);
            // 
            // btnBuildShaderPak
            // 
            this.btnBuildShaderPak.Location = new System.Drawing.Point(6, 152);
            this.btnBuildShaderPak.Name = "btnBuildShaderPak";
            this.btnBuildShaderPak.Size = new System.Drawing.Size(259, 23);
            this.btnBuildShaderPak.TabIndex = 14;
            this.btnBuildShaderPak.Text = "Build Release Shader Paks (PC)";
            this.btnBuildShaderPak.UseVisualStyleBackColor = true;
            this.btnBuildShaderPak.Click += new System.EventHandler(this.btnBuildShaderPak_Click);
            // 
            // btnVSSolution
            // 
            this.btnVSSolution.Location = new System.Drawing.Point(6, 65);
            this.btnVSSolution.Name = "btnVSSolution";
            this.btnVSSolution.Size = new System.Drawing.Size(259, 23);
            this.btnVSSolution.TabIndex = 11;
            this.btnVSSolution.Text = "Create Visual Studio Solution (.sin)...";
            this.btnVSSolution.UseVisualStyleBackColor = true;
            this.btnVSSolution.Click += new System.EventHandler(this.btnVSSolution_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(6, 94);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(259, 23);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Text = "Build Project...";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Label_VSVersion
            // 
            this.Label_VSVersion.AutoSize = true;
            this.Label_VSVersion.Location = new System.Drawing.Point(6, 16);
            this.Label_VSVersion.Name = "Label_VSVersion";
            this.Label_VSVersion.Size = new System.Drawing.Size(134, 12);
            this.Label_VSVersion.TabIndex = 7;
            this.Label_VSVersion.Text = "Visual Studio Version :";
            // 
            // btnShowWAFDialog
            // 
            this.btnShowWAFDialog.Location = new System.Drawing.Point(16, 100);
            this.btnShowWAFDialog.Name = "btnShowWAFDialog";
            this.btnShowWAFDialog.Size = new System.Drawing.Size(206, 23);
            this.btnShowWAFDialog.TabIndex = 3;
            this.btnShowWAFDialog.Text = "Open WAF Option Dialog";
            this.btnShowWAFDialog.UseVisualStyleBackColor = true;
            this.btnShowWAFDialog.Click += new System.EventHandler(this.btnShowWAFDialog_Click);
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.Location = new System.Drawing.Point(16, 42);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(206, 23);
            this.btnConfigurator.TabIndex = 6;
            this.btnConfigurator.Text = "Open Project Configurator";
            this.btnConfigurator.UseVisualStyleBackColor = true;
            this.btnConfigurator.Click += new System.EventHandler(this.btnConfigurator_Click);
            // 
            // btnAssistant
            // 
            this.btnAssistant.Location = new System.Drawing.Point(16, 71);
            this.btnAssistant.Name = "btnAssistant";
            this.btnAssistant.Size = new System.Drawing.Size(206, 23);
            this.btnAssistant.TabIndex = 7;
            this.btnAssistant.Text = "Open Setup Assistant";
            this.btnAssistant.UseVisualStyleBackColor = true;
            this.btnAssistant.Click += new System.EventHandler(this.btnAssistant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMSG_WARNING);
            this.groupBox1.Controls.Add(this.cbMSG_INFO);
            this.groupBox1.Controls.Add(this.cbMSG_SETTINGS);
            this.groupBox1.Controls.Add(this.cbMSG_WARN);
            this.groupBox1.Location = new System.Drawing.Point(538, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disable WAF message";
            // 
            // cbMSG_WARNING
            // 
            this.cbMSG_WARNING.AutoSize = true;
            this.cbMSG_WARNING.Location = new System.Drawing.Point(6, 43);
            this.cbMSG_WARNING.Name = "cbMSG_WARNING";
            this.cbMSG_WARNING.Size = new System.Drawing.Size(92, 16);
            this.cbMSG_WARNING.TabIndex = 4;
            this.cbMSG_WARNING.Text = "[WARNING]";
            this.cbMSG_WARNING.UseVisualStyleBackColor = true;
            this.cbMSG_WARNING.CheckedChanged += new System.EventHandler(this.cbMSG_WARNING_CheckedChanged);
            // 
            // cbMSG_INFO
            // 
            this.cbMSG_INFO.AutoSize = true;
            this.cbMSG_INFO.Location = new System.Drawing.Point(6, 87);
            this.cbMSG_INFO.Name = "cbMSG_INFO";
            this.cbMSG_INFO.Size = new System.Drawing.Size(64, 16);
            this.cbMSG_INFO.TabIndex = 2;
            this.cbMSG_INFO.Text = "[INFO]";
            this.cbMSG_INFO.UseVisualStyleBackColor = true;
            this.cbMSG_INFO.CheckedChanged += new System.EventHandler(this.cbMSG_INFO_CheckedChanged);
            // 
            // cbMSG_SETTINGS
            // 
            this.cbMSG_SETTINGS.AutoSize = true;
            this.cbMSG_SETTINGS.Location = new System.Drawing.Point(6, 65);
            this.cbMSG_SETTINGS.Name = "cbMSG_SETTINGS";
            this.cbMSG_SETTINGS.Size = new System.Drawing.Size(97, 16);
            this.cbMSG_SETTINGS.TabIndex = 1;
            this.cbMSG_SETTINGS.Text = "[SETTINGS]";
            this.cbMSG_SETTINGS.UseVisualStyleBackColor = true;
            this.cbMSG_SETTINGS.CheckedChanged += new System.EventHandler(this.cbMSG_SETTINGS_CheckedChanged);
            // 
            // cbMSG_WARN
            // 
            this.cbMSG_WARN.AutoSize = true;
            this.cbMSG_WARN.Location = new System.Drawing.Point(6, 20);
            this.cbMSG_WARN.Name = "cbMSG_WARN";
            this.cbMSG_WARN.Size = new System.Drawing.Size(71, 16);
            this.cbMSG_WARN.TabIndex = 0;
            this.cbMSG_WARN.Text = "[WARN]";
            this.cbMSG_WARN.UseVisualStyleBackColor = true;
            this.cbMSG_WARN.CheckedChanged += new System.EventHandler(this.cbMSG_WARN_CheckedChanged);
            // 
            // btnLaunchEditor
            // 
            this.btnLaunchEditor.Location = new System.Drawing.Point(16, 13);
            this.btnLaunchEditor.Name = "btnLaunchEditor";
            this.btnLaunchEditor.Size = new System.Drawing.Size(206, 23);
            this.btnLaunchEditor.TabIndex = 9;
            this.btnLaunchEditor.Text = "Launch Editor";
            this.btnLaunchEditor.UseVisualStyleBackColor = true;
            this.btnLaunchEditor.Click += new System.EventHandler(this.btnLaunchEditor_Click);
            // 
            // groupBox_Lumberyard
            // 
            this.groupBox_Lumberyard.Controls.Add(this.btnAssistant);
            this.groupBox_Lumberyard.Controls.Add(this.btnShowWAFDialog);
            this.groupBox_Lumberyard.Controls.Add(this.btnLaunchEditor);
            this.groupBox_Lumberyard.Controls.Add(this.btnConfigurator);
            this.groupBox_Lumberyard.Location = new System.Drawing.Point(291, 12);
            this.groupBox_Lumberyard.Name = "groupBox_Lumberyard";
            this.groupBox_Lumberyard.Size = new System.Drawing.Size(241, 131);
            this.groupBox_Lumberyard.TabIndex = 11;
            this.groupBox_Lumberyard.TabStop = false;
            this.groupBox_Lumberyard.Text = "Lumberyard Tools";
            // 
            // btnBreak
            // 
            this.btnBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreak.Enabled = false;
            this.btnBreak.Location = new System.Drawing.Point(403, 491);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(119, 29);
            this.btnBreak.TabIndex = 17;
            this.btnBreak.Text = "Force Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // cbWordWrap
            // 
            this.cbWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWordWrap.AutoSize = true;
            this.cbWordWrap.Location = new System.Drawing.Point(12, 491);
            this.cbWordWrap.Name = "cbWordWrap";
            this.cbWordWrap.Size = new System.Drawing.Size(80, 16);
            this.cbWordWrap.TabIndex = 16;
            this.cbWordWrap.Text = "WordWrap";
            this.cbWordWrap.UseVisualStyleBackColor = true;
            this.cbWordWrap.CheckedChanged += new System.EventHandler(this.cbWordWrap_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(528, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.Location = new System.Drawing.Point(653, 491);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(119, 29);
            this.btnSaveOutput.TabIndex = 13;
            this.btnSaveOutput.Text = "Save output...";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // SaveRTF
            // 
            this.SaveRTF.DefaultExt = "rtf";
            this.SaveRTF.Filter = "\"RTF Text|*.rtf|All files|*.*\"";
            // 
            // linkLumberyard
            // 
            this.linkLumberyard.AutoSize = true;
            this.linkLumberyard.Location = new System.Drawing.Point(289, 146);
            this.linkLumberyard.Name = "linkLumberyard";
            this.linkLumberyard.Size = new System.Drawing.Size(181, 12);
            this.linkLumberyard.TabIndex = 14;
            this.linkLumberyard.TabStop = true;
            this.linkLumberyard.Text = "[ Lumberyard official website ]";
            this.linkLumberyard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLumberyard_LinkClicked);
            // 
            // linkLYGithub
            // 
            this.linkLYGithub.AutoSize = true;
            this.linkLYGithub.Location = new System.Drawing.Point(289, 164);
            this.linkLYGithub.Name = "linkLYGithub";
            this.linkLYGithub.Size = new System.Drawing.Size(134, 12);
            this.linkLYGithub.TabIndex = 15;
            this.linkLYGithub.TabStop = true;
            this.linkLYGithub.Text = "[ Lumberyard GitHub ]";
            this.linkLYGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLYGithub_LinkClicked);
            // 
            // linkUserGuide
            // 
            this.linkUserGuide.AutoSize = true;
            this.linkUserGuide.Location = new System.Drawing.Point(289, 182);
            this.linkUserGuide.Name = "linkUserGuide";
            this.linkUserGuide.Size = new System.Drawing.Size(209, 12);
            this.linkUserGuide.TabIndex = 16;
            this.linkUserGuide.TabStop = true;
            this.linkUserGuide.Text = "[ Lumberyard User guide (GitHub) ]";
            this.linkUserGuide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserGuide_LinkClicked);
            // 
            // linkSourceCode
            // 
            this.linkSourceCode.AutoSize = true;
            this.linkSourceCode.Location = new System.Drawing.Point(520, 146);
            this.linkSourceCode.Name = "linkSourceCode";
            this.linkSourceCode.Size = new System.Drawing.Size(171, 12);
            this.linkSourceCode.TabIndex = 18;
            this.linkSourceCode.TabStop = true;
            this.linkSourceCode.Text = "[ Get Source code (GitHub) ]";
            this.linkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSourceCode_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linkSourceCode);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.linkUserGuide);
            this.Controls.Add(this.cbWordWrap);
            this.Controls.Add(this.linkLYGithub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.linkLumberyard);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.groupBox_Lumberyard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_ProjectInfo);
            this.Controls.Add(this.Label_Progress);
            this.Controls.Add(this.ProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "LY Command Helper [Lumberyard : 1.19.0]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_ProjectInfo.ResumeLayout(false);
            this.groupBox_ProjectInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Lumberyard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label Label_Progress;
        private System.Windows.Forms.GroupBox groupBox_ProjectInfo;
        private System.Windows.Forms.Button btnShowWAFDialog;
        private System.Windows.Forms.Button btnAssistant;
        private System.Windows.Forms.Button btnConfigurator;
        private System.Windows.Forms.Label Label_VSVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMSG_INFO;
        private System.Windows.Forms.CheckBox cbMSG_SETTINGS;
        private System.Windows.Forms.CheckBox cbMSG_WARN;
        private System.Windows.Forms.Button btnVSSolution;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.GroupBox groupBox_Lumberyard;
        private System.Windows.Forms.Button btnLaunchEditor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.CheckBox cbMSG_WARNING;
        private System.Windows.Forms.CheckBox cbWordWrap;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.SaveFileDialog SaveRTF;
        private System.Windows.Forms.Button btnBuildShaderPak;
        private System.Windows.Forms.Button btnBuildProjectPak;
        private System.Windows.Forms.LinkLabel linkLumberyard;
        private System.Windows.Forms.LinkLabel linkLYGithub;
        private System.Windows.Forms.LinkLabel linkUserGuide;
        private System.Windows.Forms.LinkLabel linkSourceCode;
    }
}

