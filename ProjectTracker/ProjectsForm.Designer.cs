namespace ProjectTracker
{
    partial class ProjectsForm
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
            this.components = new System.ComponentModel.Container();
            this.addProjectButton = new MaterialSkin.Controls.MaterialButton();
            this.userLabel = new MaterialSkin.Controls.MaterialLabel();
            this.projectTimer = new System.Windows.Forms.Timer(this.components);
            this.timerDisplayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.showStatisticsButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // addProjectButton
            // 
            this.addProjectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProjectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addProjectButton.Depth = 0;
            this.addProjectButton.HighEmphasis = true;
            this.addProjectButton.Icon = null;
            this.addProjectButton.Location = new System.Drawing.Point(788, 198);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addProjectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addProjectButton.Size = new System.Drawing.Size(154, 36);
            this.addProjectButton.TabIndex = 0;
            this.addProjectButton.Text = "add new project";
            this.addProjectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addProjectButton.UseAccentColor = false;
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Depth = 0;
            this.userLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userLabel.Location = new System.Drawing.Point(785, 133);
            this.userLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(70, 19);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "userLabel";
            // 
            // projectTimer
            // 
            this.projectTimer.Interval = 1000;
            // 
            // timerDisplayLabel
            // 
            this.timerDisplayLabel.AutoSize = true;
            this.timerDisplayLabel.Depth = 0;
            this.timerDisplayLabel.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timerDisplayLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.timerDisplayLabel.Location = new System.Drawing.Point(753, 485);
            this.timerDisplayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timerDisplayLabel.Name = "timerDisplayLabel";
            this.timerDisplayLabel.Size = new System.Drawing.Size(225, 72);
            this.timerDisplayLabel.TabIndex = 2;
            this.timerDisplayLabel.Text = "00:00:00";
            // 
            // showStatisticsButton
            // 
            this.showStatisticsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showStatisticsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.showStatisticsButton.Depth = 0;
            this.showStatisticsButton.HighEmphasis = true;
            this.showStatisticsButton.Icon = null;
            this.showStatisticsButton.Location = new System.Drawing.Point(788, 660);
            this.showStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showStatisticsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showStatisticsButton.Name = "showStatisticsButton";
            this.showStatisticsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showStatisticsButton.Size = new System.Drawing.Size(148, 36);
            this.showStatisticsButton.TabIndex = 3;
            this.showStatisticsButton.Text = "Show Statistics";
            this.showStatisticsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showStatisticsButton.UseAccentColor = false;
            this.showStatisticsButton.UseVisualStyleBackColor = true;
            this.showStatisticsButton.Click += new System.EventHandler(this.showStatisticsButton_Click);
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1139, 1254);
            this.Controls.Add(this.showStatisticsButton);
            this.Controls.Add(this.timerDisplayLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.addProjectButton);
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton addProjectButton;
        private MaterialSkin.Controls.MaterialLabel userLabel;
        private System.Windows.Forms.Timer projectTimer;
        private MaterialSkin.Controls.MaterialLabel timerDisplayLabel;
        private MaterialSkin.Controls.MaterialButton showStatisticsButton;
    }
}