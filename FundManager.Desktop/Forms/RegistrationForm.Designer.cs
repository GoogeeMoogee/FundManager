namespace FundManager.Desktop.Forms
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ValidationPanel = new System.Windows.Forms.Panel();
            this.ValidationErrorsLabel = new System.Windows.Forms.Label();
            this.ValidationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(132, 19);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(217, 21);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Please fill registration form";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(242, 79);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(40, 77);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(88, 21);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "UserName";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(242, 119);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(199, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(40, 117);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 21);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(242, 159);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(199, 20);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(40, 157);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(84, 21);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(40, 197);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(150, 21);
            this.ConfirmPasswordLabel.TabIndex = 6;
            this.ConfirmPasswordLabel.Text = "Confirm password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(242, 199);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(199, 20);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(309, 274);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(132, 46);
            this.RegistrationButton.TabIndex = 9;
            this.RegistrationButton.Text = "Register";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // ValidationPanel
            // 
            this.ValidationPanel.Controls.Add(this.ValidationErrorsLabel);
            this.ValidationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValidationPanel.Location = new System.Drawing.Point(0, 326);
            this.ValidationPanel.Name = "ValidationPanel";
            this.ValidationPanel.Size = new System.Drawing.Size(493, 70);
            this.ValidationPanel.TabIndex = 10;
            // 
            // ValidationErrorsLabel
            // 
            this.ValidationErrorsLabel.AutoSize = true;
            this.ValidationErrorsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValidationErrorsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ValidationErrorsLabel.Location = new System.Drawing.Point(0, 0);
            this.ValidationErrorsLabel.Name = "ValidationErrorsLabel";
            this.ValidationErrorsLabel.Size = new System.Drawing.Size(0, 13);
            this.ValidationErrorsLabel.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 396);
            this.Controls.Add(this.ValidationPanel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ValidationPanel.ResumeLayout(false);
            this.ValidationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Panel ValidationPanel;
        private System.Windows.Forms.Label ValidationErrorsLabel;
    }
}