namespace LYCommandHelper
{
    partial class BuildOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfig = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btBuild = new System.Windows.Forms.Button();
            this.Label_BuildOption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.cbUserInput = new System.Windows.Forms.CheckBox();
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration :";
            // 
            // cbConfig
            // 
            this.cbConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfig.FormattingEnabled = true;
            this.cbConfig.Items.AddRange(new object[] {
            "profile",
            "profile_dedicated",
            "profile_test",
            "profile_test_dedicated",
            "release",
            "release_dedicated",
            "performance",
            "performance_dedicated",
            "debug",
            "debug_dedicated",
            "debug_test",
            "debug_test_dedicated"});
            this.cbConfig.Location = new System.Drawing.Point(105, 6);
            this.cbConfig.MaxDropDownItems = 12;
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(162, 20);
            this.cbConfig.TabIndex = 1;
            this.cbConfig.SelectedIndexChanged += new System.EventHandler(this.cbConfig_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(431, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btBuild
            // 
            this.btBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuild.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btBuild.Location = new System.Drawing.Point(350, 98);
            this.btBuild.Name = "btBuild";
            this.btBuild.Size = new System.Drawing.Size(75, 23);
            this.btBuild.TabIndex = 3;
            this.btBuild.Text = "Build";
            this.btBuild.UseVisualStyleBackColor = true;
            this.btBuild.Click += new System.EventHandler(this.btBuild_Click);
            // 
            // Label_BuildOption
            // 
            this.Label_BuildOption.AutoSize = true;
            this.Label_BuildOption.Location = new System.Drawing.Point(12, 43);
            this.Label_BuildOption.Name = "Label_BuildOption";
            this.Label_BuildOption.Size = new System.Drawing.Size(85, 12);
            this.Label_BuildOption.TabIndex = 4;
            this.Label_BuildOption.Text = "Build Option : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spec :";
            // 
            // cbSpec
            // 
            this.cbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(326, 6);
            this.cbSpec.MaxDropDownItems = 12;
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(180, 20);
            this.cbSpec.TabIndex = 6;
            this.cbSpec.SelectedIndexChanged += new System.EventHandler(this.cbSpec_SelectedIndexChanged);
            // 
            // cbUserInput
            // 
            this.cbUserInput.AutoSize = true;
            this.cbUserInput.Location = new System.Drawing.Point(14, 67);
            this.cbUserInput.Name = "cbUserInput";
            this.cbUserInput.Size = new System.Drawing.Size(89, 16);
            this.cbUserInput.TabIndex = 7;
            this.cbUserInput.Text = "User input :";
            this.cbUserInput.UseVisualStyleBackColor = true;
            this.cbUserInput.CheckedChanged += new System.EventHandler(this.cbUserInput_CheckedChanged);
            // 
            // tbUserInput
            // 
            this.tbUserInput.Enabled = false;
            this.tbUserInput.Location = new System.Drawing.Point(109, 62);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(397, 21);
            this.tbUserInput.TabIndex = 8;
            // 
            // BuildOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 133);
            this.ControlBox = false;
            this.Controls.Add(this.tbUserInput);
            this.Controls.Add(this.cbUserInput);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_BuildOption);
            this.Controls.Add(this.btBuild);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbConfig);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuildOption";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build option";
            this.Load += new System.EventHandler(this.BuildOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBuild;
        private System.Windows.Forms.Label Label_BuildOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.CheckBox cbUserInput;
        private System.Windows.Forms.TextBox tbUserInput;
    }
}