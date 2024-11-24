namespace ProjectTracker
{
    partial class AddProjectForm
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
            this.projectNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.AnimateReadOnly = false;
            this.projectNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.projectNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.projectNameTextBox.Depth = 0;
            this.projectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.projectNameTextBox.HideSelection = true;
            this.projectNameTextBox.LeadingIcon = null;
            this.projectNameTextBox.Location = new System.Drawing.Point(48, 135);
            this.projectNameTextBox.MaxLength = 32767;
            this.projectNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.PasswordChar = '\0';
            this.projectNameTextBox.PrefixSuffixText = null;
            this.projectNameTextBox.ReadOnly = false;
            this.projectNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectNameTextBox.SelectedText = "";
            this.projectNameTextBox.SelectionLength = 0;
            this.projectNameTextBox.SelectionStart = 0;
            this.projectNameTextBox.ShortcutsEnabled = true;
            this.projectNameTextBox.Size = new System.Drawing.Size(250, 48);
            this.projectNameTextBox.TabIndex = 0;
            this.projectNameTextBox.TabStop = false;
            this.projectNameTextBox.Text = "project name";
            this.projectNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectNameTextBox.TrailingIcon = null;
            this.projectNameTextBox.UseSystemPasswordChar = false;
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(48, 236);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(64, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 390);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.projectNameTextBox);
            this.Name = "AddProjectForm";
            this.Text = "addProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 projectNameTextBox;
        private MaterialSkin.Controls.MaterialButton addButton;
    }
}