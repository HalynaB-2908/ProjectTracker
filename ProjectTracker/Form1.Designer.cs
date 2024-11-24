namespace ProjectTracker
{
    partial class RegistrationForm
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
            this.userNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.userNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.eMailTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.eMailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.signUpButton = new MaterialSkin.Controls.MaterialButton();
            this.signInButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.togglePasswordVisibility = new MaterialSkin.Controls.MaterialCheckbox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.AnimateReadOnly = false;
            this.userNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNameTextBox.Depth = 0;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameTextBox.HideSelection = true;
            this.userNameTextBox.LeadingIcon = null;
            this.userNameTextBox.Location = new System.Drawing.Point(210, 161);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PrefixSuffixText = null;
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(310, 48);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextBox.TrailingIcon = null;
            this.userNameTextBox.UseSystemPasswordChar = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Depth = 0;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameLabel.Location = new System.Drawing.Point(60, 190);
            this.userNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(72, 19);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.AnimateReadOnly = false;
            this.eMailTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eMailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eMailTextBox.Depth = 0;
            this.eMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eMailTextBox.HideSelection = true;
            this.eMailTextBox.LeadingIcon = null;
            this.eMailTextBox.Location = new System.Drawing.Point(210, 254);
            this.eMailTextBox.MaxLength = 32767;
            this.eMailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.PasswordChar = '\0';
            this.eMailTextBox.PrefixSuffixText = null;
            this.eMailTextBox.ReadOnly = false;
            this.eMailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eMailTextBox.SelectedText = "";
            this.eMailTextBox.SelectionLength = 0;
            this.eMailTextBox.SelectionStart = 0;
            this.eMailTextBox.ShortcutsEnabled = true;
            this.eMailTextBox.Size = new System.Drawing.Size(310, 48);
            this.eMailTextBox.TabIndex = 6;
            this.eMailTextBox.TabStop = false;
            this.eMailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eMailTextBox.TrailingIcon = null;
            this.eMailTextBox.UseSystemPasswordChar = false;
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Depth = 0;
            this.eMailLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eMailLabel.Location = new System.Drawing.Point(60, 283);
            this.eMailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(45, 19);
            this.eMailLabel.TabIndex = 5;
            this.eMailLabel.Text = "E-Mail";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(210, 358);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(310, 48);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(60, 387);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = false;
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUpButton.Depth = 0;
            this.signUpButton.HighEmphasis = true;
            this.signUpButton.Icon = null;
            this.signUpButton.Location = new System.Drawing.Point(210, 462);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUpButton.Size = new System.Drawing.Size(310, 36);
            this.signUpButton.TabIndex = 9;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signUpButton.UseAccentColor = false;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.AutoSize = false;
            this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signInButton.Depth = 0;
            this.signInButton.HighEmphasis = true;
            this.signInButton.Icon = null;
            this.signInButton.Location = new System.Drawing.Point(210, 525);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInButton.Name = "signInButton";
            this.signInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signInButton.Size = new System.Drawing.Size(310, 36);
            this.signInButton.TabIndex = 10;
            this.signInButton.Text = "Sign In";
            this.signInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signInButton.UseAccentColor = false;
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjectTracker.Properties.Resources.pngegg__2_;
            this.pictureBox1.Location = new System.Drawing.Point(727, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 514);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // togglePasswordVisibility
            // 
            this.togglePasswordVisibility.AutoSize = true;
            this.togglePasswordVisibility.Depth = 0;
            this.togglePasswordVisibility.Location = new System.Drawing.Point(550, 369);
            this.togglePasswordVisibility.Margin = new System.Windows.Forms.Padding(0);
            this.togglePasswordVisibility.MouseLocation = new System.Drawing.Point(-1, -1);
            this.togglePasswordVisibility.MouseState = MaterialSkin.MouseState.HOVER;
            this.togglePasswordVisibility.Name = "togglePasswordVisibility";
            this.togglePasswordVisibility.ReadOnly = false;
            this.togglePasswordVisibility.Ripple = true;
            this.togglePasswordVisibility.Size = new System.Drawing.Size(35, 37);
            this.togglePasswordVisibility.TabIndex = 11;
            this.toolTip1.SetToolTip(this.togglePasswordVisibility, "Show password\r\n");
            this.togglePasswordVisibility.UseVisualStyleBackColor = true;
            this.togglePasswordVisibility.CheckedChanged += new System.EventHandler(this.togglePasswordVisibility_CheckedChanged);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(59, 810);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(241, 20);
            this.registerLink.TabIndex = 13;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Don\'t have an account? Register";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked_1);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 901);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.togglePasswordVisibility);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.eMailLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 userNameTextBox;
        private MaterialSkin.Controls.MaterialLabel userNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 eMailTextBox;
        private MaterialSkin.Controls.MaterialLabel eMailLabel;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialButton signUpButton;
        private MaterialSkin.Controls.MaterialButton signInButton;
        private MaterialSkin.Controls.MaterialCheckbox togglePasswordVisibility;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

