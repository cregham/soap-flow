
namespace ui
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersLabel = new System.Windows.Forms.Label();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.Errors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.SelectedUserLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ClearSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(12, 9);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 5;
            this.UsersLabel.Text = "Users";
            // 
            // UserListBox
            // 
            this.UserListBox.DisplayMember = "Name";
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(12, 26);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(191, 342);
            this.UserListBox.TabIndex = 9;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            this.UserListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.UserListBox_Format);
            // 
            // Errors
            // 
            this.Errors.Location = new System.Drawing.Point(443, 258);
            this.Errors.Multiline = true;
            this.Errors.Name = "Errors";
            this.Errors.ReadOnly = true;
            this.Errors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Errors.Size = new System.Drawing.Size(231, 110);
            this.Errors.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Errors";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(446, 138);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(107, 43);
            this.DeleteUserButton.TabIndex = 12;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // SelectedUserLabel
            // 
            this.SelectedUserLabel.AutoSize = true;
            this.SelectedUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedUserLabel.Location = new System.Drawing.Point(209, 72);
            this.SelectedUserLabel.Name = "SelectedUserLabel";
            this.SelectedUserLabel.Size = new System.Drawing.Size(123, 20);
            this.SelectedUserLabel.TabIndex = 14;
            this.SelectedUserLabel.Text = "Selected User";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(213, 112);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(107, 20);
            this.IDTextBox.TabIndex = 15;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(213, 96);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 16;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(326, 96);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(329, 112);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(107, 20);
            this.NameTextBox.TabIndex = 18;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(446, 95);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 20;
            this.AgeLabel.Text = "Age";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(329, 138);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(107, 43);
            this.AddUserButton.TabIndex = 21;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AgeNumericUpDown
            // 
            this.AgeNumericUpDown.Location = new System.Drawing.Point(446, 112);
            this.AgeNumericUpDown.Name = "AgeNumericUpDown";
            this.AgeNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.AgeNumericUpDown.TabIndex = 22;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(213, 138);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(107, 43);
            this.SaveChangesButton.TabIndex = 23;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ClearSelectionButton
            // 
            this.ClearSelectionButton.Location = new System.Drawing.Point(209, 26);
            this.ClearSelectionButton.Name = "ClearSelectionButton";
            this.ClearSelectionButton.Size = new System.Drawing.Size(94, 43);
            this.ClearSelectionButton.TabIndex = 24;
            this.ClearSelectionButton.Text = "Clear Selection";
            this.ClearSelectionButton.UseVisualStyleBackColor = true;
            this.ClearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.ClearSelectionButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.AgeNumericUpDown);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.SelectedUserLabel);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.UsersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.TextBox Errors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Label SelectedUserLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.NumericUpDown AgeNumericUpDown;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button ClearSelectionButton;
    }
}

