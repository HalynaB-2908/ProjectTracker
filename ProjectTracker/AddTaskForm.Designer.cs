namespace ProjectTracker
{
    partial class AddTaskForm
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
            this.taskNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.taskComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteTaskButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.AnimateReadOnly = false;
            this.taskNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.taskNameTextBox.Depth = 0;
            this.taskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.taskNameTextBox.HideSelection = true;
            this.taskNameTextBox.LeadingIcon = null;
            this.taskNameTextBox.Location = new System.Drawing.Point(38, 127);
            this.taskNameTextBox.MaxLength = 32767;
            this.taskNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PasswordChar = '\0';
            this.taskNameTextBox.PrefixSuffixText = null;
            this.taskNameTextBox.ReadOnly = false;
            this.taskNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskNameTextBox.SelectedText = "";
            this.taskNameTextBox.SelectionLength = 0;
            this.taskNameTextBox.SelectionStart = 0;
            this.taskNameTextBox.ShortcutsEnabled = true;
            this.taskNameTextBox.Size = new System.Drawing.Size(284, 48);
            this.taskNameTextBox.TabIndex = 1;
            this.taskNameTextBox.TabStop = false;
            this.taskNameTextBox.Text = "task name";
            this.taskNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.taskNameTextBox.TrailingIcon = null;
            this.taskNameTextBox.UseSystemPasswordChar = false;
            // 
            // taskComboBox
            // 
            this.taskComboBox.AutoResize = false;
            this.taskComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskComboBox.Depth = 0;
            this.taskComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.taskComboBox.DropDownHeight = 174;
            this.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskComboBox.DropDownWidth = 121;
            this.taskComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.taskComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.taskComboBox.FormattingEnabled = true;
            this.taskComboBox.IntegralHeight = false;
            this.taskComboBox.ItemHeight = 43;
            this.taskComboBox.Location = new System.Drawing.Point(38, 211);
            this.taskComboBox.MaxDropDownItems = 4;
            this.taskComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(284, 49);
            this.taskComboBox.StartIndex = 0;
            this.taskComboBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.taskComboBox, "select task to delete");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.IsBalloon = true;
            // 
            // addTaskButton
            // 
            this.addTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addTaskButton.Depth = 0;
            this.addTaskButton.HighEmphasis = true;
            this.addTaskButton.Icon = null;
            this.addTaskButton.Location = new System.Drawing.Point(38, 298);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addTaskButton.Size = new System.Drawing.Size(91, 36);
            this.addTaskButton.TabIndex = 3;
            this.addTaskButton.Text = "add Task";
            this.addTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addTaskButton.UseAccentColor = false;
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteTaskButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteTaskButton.Depth = 0;
            this.deleteTaskButton.HighEmphasis = true;
            this.deleteTaskButton.Icon = null;
            this.deleteTaskButton.Location = new System.Drawing.Point(208, 298);
            this.deleteTaskButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteTaskButton.Size = new System.Drawing.Size(114, 36);
            this.deleteTaskButton.TabIndex = 4;
            this.deleteTaskButton.Text = "delete Task";
            this.deleteTaskButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteTaskButton.UseAccentColor = false;
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.taskComboBox);
            this.Controls.Add(this.taskNameTextBox);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 taskNameTextBox;
        private MaterialSkin.Controls.MaterialComboBox taskComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialButton addTaskButton;
        private MaterialSkin.Controls.MaterialButton deleteTaskButton;
    }
}