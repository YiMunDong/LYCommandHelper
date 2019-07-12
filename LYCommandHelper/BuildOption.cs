using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LYCommandHelper
{
    public partial class BuildOption : Form
    {
        public string CommandOption;

        public Configuration Config;

        public BuildOption()
        {
            InitializeComponent();
        }

        private void BuildOption_Load(object sender, EventArgs e)
        {
            cbConfig.SelectedItem = Config.BuildConfig;

            cbSpec.Items.Add(Config.Current_ProjectName);
            cbSpec.Items.Add("all");
            cbSpec.Items.Add("game");
            cbSpec.Items.Add("game_and_engine");

            if (cbSpec.Items.IndexOf(Config.BuildSpec) >= 0)
                cbSpec.SelectedItem = Config.BuildSpec;
            else
                cbSpec.SelectedItem = "all";


            cbUserInput.Checked = Config.BuildUsingUserInput;
            tbUserInput.Text = Config.BuildUserInput;

            UpdateBuildOption();
        }

        private void btBuild_Click(object sender, EventArgs e)
        {
            Config.BuildUserInput = tbUserInput.Text;
        }

        private void cbConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.BuildConfig = cbConfig.Text;
            UpdateBuildOption();
        }

        private void cbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.BuildSpec = cbSpec.Text;
            UpdateBuildOption();
        }

        private void UpdateBuildOption()
        {
            CommandOption = "build_win_x64_vs" + Config.Current_VSVersion + "_"
                + cbConfig.Text
                + " -p "
                + cbSpec.Text;

            Label_BuildOption.Text = "Build Option : " + CommandOption;
        }

        private void cbUserInput_CheckedChanged(object sender, EventArgs e)
        {
            Config.BuildUsingUserInput = cbUserInput.Checked;
            tbUserInput.Enabled = cbUserInput.Checked;
        }        
    }
}
