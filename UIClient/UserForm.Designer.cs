
namespace UserClient
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
            this.GetUsersButton = new System.Windows.Forms.Button();
            this.ManualErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientErrorLabel = new System.Windows.Forms.Label();
            this.ManualListBox = new System.Windows.Forms.ListBox();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetUsersButton
            // 
            this.GetUsersButton.Location = new System.Drawing.Point(12, 12);
            this.GetUsersButton.Name = "GetUsersButton";
            this.GetUsersButton.Size = new System.Drawing.Size(152, 73);
            this.GetUsersButton.TabIndex = 0;
            this.GetUsersButton.Text = "Get Users";
            this.GetUsersButton.UseVisualStyleBackColor = true;
            this.GetUsersButton.Click += new System.EventHandler(this.GetUsersButton_Click);
            // 
            // ManualErrorLabel
            // 
            this.ManualErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManualErrorLabel.AutoSize = true;
            this.ManualErrorLabel.Location = new System.Drawing.Point(329, 121);
            this.ManualErrorLabel.Name = "ManualErrorLabel";
            this.ManualErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ManualErrorLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // ClientErrorLabel
            // 
            this.ClientErrorLabel.AutoSize = true;
            this.ClientErrorLabel.Location = new System.Drawing.Point(329, 140);
            this.ClientErrorLabel.Name = "ClientErrorLabel";
            this.ClientErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ClientErrorLabel.TabIndex = 7;
            // 
            // ManualListBox
            // 
            this.ManualListBox.FormattingEnabled = true;
            this.ManualListBox.ItemHeight = 15;
            this.ManualListBox.Location = new System.Drawing.Point(12, 121);
            this.ManualListBox.Name = "ManualListBox";
            this.ManualListBox.Size = new System.Drawing.Size(152, 289);
            this.ManualListBox.TabIndex = 8;
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 15;
            this.ClientListBox.Location = new System.Drawing.Point(171, 122);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(152, 289);
            this.ClientListBox.TabIndex = 9;
            // 
            // ClientListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientListBox);
            this.Controls.Add(this.ManualListBox);
            this.Controls.Add(this.ClientErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManualErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetUsersButton);
            this.Name = "ClientListView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetUsersButton;
        private System.Windows.Forms.Label ManualErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ClientErrorLabel;
        private System.Windows.Forms.ListBox ManualListBox;
        private System.Windows.Forms.ListBox ClientListBox;
    }
}

