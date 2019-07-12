using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LYCommandHelper
{
    public partial class VSSolution : Form
    {
        public Configuration Config;
        public string CommandOption;

        public VSSolution()
        {
            InitializeComponent();
        }

        private void VSSolution_Load(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            rbProject.Text = "msvs -p " + Config.Current_ProjectName;

            RadioButton[] OptionList = new RadioButton[] {
                rbAll, rbProject, rbGame, rbGameAndEngine};

            foreach(RadioButton Op in OptionList)
            {
                if(Op.Text.Equals(Config.CreateVSSelect))
                {
                    Op.Checked = true;
                    return;
                }
            }
        }

        private void OnChange_Option(object sender, EventArgs e)
        {
            RadioButton Option = sender as RadioButton;
            CommandOption = Option.Text;
            Config.CreateVSSelect = Option.Text;
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if(cbClean.Checked)
            {
                foreach (var directory in Directory.GetDirectories(Config.Current_Solution_Dir))
                {
                    Directory.Delete(directory, true);
                }

                foreach(var file in Directory.GetFiles(Config.Current_Solution_Dir))
                {
                    File.Delete(file);
                }
            }
        }
    }
}
