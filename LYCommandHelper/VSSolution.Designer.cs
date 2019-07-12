namespace LYCommandHelper
{
    partial class VSSolution
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
            this.btGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbGame = new System.Windows.Forms.RadioButton();
            this.rbProject = new System.Windows.Forms.RadioButton();
            this.rbGameAndEngine = new System.Windows.Forms.RadioButton();
            this.cbClean = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btGenerate.Location = new System.Drawing.Point(121, 148);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(202, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(12, 12);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(54, 16);
            this.rbAll.TabIndex = 2;
            this.rbAll.Text = "msvs";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.OnChange_Option);
            // 
            // rbGame
            // 
            this.rbGame.AutoSize = true;
            this.rbGame.Location = new System.Drawing.Point(12, 56);
            this.rbGame.Name = "rbGame";
            this.rbGame.Size = new System.Drawing.Size(107, 16);
            this.rbGame.TabIndex = 3;
            this.rbGame.Text = "msvs -p game";
            this.rbGame.UseVisualStyleBackColor = true;
            this.rbGame.CheckedChanged += new System.EventHandler(this.OnChange_Option);
            // 
            // rbProject
            // 
            this.rbProject.AutoSize = true;
            this.rbProject.Location = new System.Drawing.Point(12, 34);
            this.rbProject.Name = "rbProject";
            this.rbProject.Size = new System.Drawing.Size(132, 16);
            this.rbProject.TabIndex = 4;
            this.rbProject.Text = "msvs -p MyProject";
            this.rbProject.UseVisualStyleBackColor = true;
            this.rbProject.CheckedChanged += new System.EventHandler(this.OnChange_Option);
            // 
            // rbGameAndEngine
            // 
            this.rbGameAndEngine.AutoSize = true;
            this.rbGameAndEngine.Location = new System.Drawing.Point(12, 78);
            this.rbGameAndEngine.Name = "rbGameAndEngine";
            this.rbGameAndEngine.Size = new System.Drawing.Size(178, 16);
            this.rbGameAndEngine.TabIndex = 5;
            this.rbGameAndEngine.Text = "msvs -p game_and_engine";
            this.rbGameAndEngine.UseVisualStyleBackColor = true;
            this.rbGameAndEngine.CheckedChanged += new System.EventHandler(this.OnChange_Option);
            // 
            // cbClean
            // 
            this.cbClean.AutoSize = true;
            this.cbClean.Location = new System.Drawing.Point(12, 113);
            this.cbClean.Name = "cbClean";
            this.cbClean.Size = new System.Drawing.Size(140, 16);
            this.cbClean.TabIndex = 6;
            this.cbClean.Text = "Clean solution folder";
            this.cbClean.UseVisualStyleBackColor = true;
            // 
            // VSSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 183);
            this.ControlBox = false;
            this.Controls.Add(this.cbClean);
            this.Controls.Add(this.rbGameAndEngine);
            this.Controls.Add(this.rbProject);
            this.Controls.Add(this.rbGame);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VSSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create visual studio solution";
            this.Load += new System.EventHandler(this.VSSolution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbGame;
        private System.Windows.Forms.RadioButton rbProject;
        private System.Windows.Forms.RadioButton rbGameAndEngine;
        private System.Windows.Forms.CheckBox cbClean;
    }
}