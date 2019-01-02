namespace FundManager.Desktop.Controls
{
    partial class NotAuthorizedControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotAuthorisedText = new System.Windows.Forms.Label();
            this.SignInLink = new System.Windows.Forms.LinkLabel();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.PleaseLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotAuthorisedText
            // 
            this.NotAuthorisedText.AutoSize = true;
            this.NotAuthorisedText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAuthorisedText.Location = new System.Drawing.Point(28, 11);
            this.NotAuthorisedText.Name = "NotAuthorisedText";
            this.NotAuthorisedText.Size = new System.Drawing.Size(289, 23);
            this.NotAuthorisedText.TabIndex = 0;
            this.NotAuthorisedText.Text = "Currently you are not authorised. ";
            // 
            // SignInLink
            // 
            this.SignInLink.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.SignInLink.AutoSize = true;
            this.SignInLink.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.SignInLink.Location = new System.Drawing.Point(87, 46);
            this.SignInLink.Name = "SignInLink";
            this.SignInLink.Size = new System.Drawing.Size(63, 23);
            this.SignInLink.TabIndex = 1;
            this.SignInLink.TabStop = true;
            this.SignInLink.Text = "SignIn";
            this.SignInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLink_LinkClicked);
            // 
            // SignUpLink
            // 
            this.SignUpLink.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.SignUpLink.Location = new System.Drawing.Point(170, 46);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(72, 23);
            this.SignUpLink.TabIndex = 2;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "SignUp";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // PleaseLabel
            // 
            this.PleaseLabel.AutoSize = true;
            this.PleaseLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseLabel.Location = new System.Drawing.Point(28, 46);
            this.PleaseLabel.Name = "PleaseLabel";
            this.PleaseLabel.Size = new System.Drawing.Size(63, 23);
            this.PleaseLabel.TabIndex = 3;
            this.PleaseLabel.Text = "Please";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.Location = new System.Drawing.Point(145, 46);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(28, 23);
            this.OrLabel.TabIndex = 4;
            this.OrLabel.Text = "or";
            // 
            // NotAuthorizedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PleaseLabel);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.SignInLink);
            this.Controls.Add(this.NotAuthorisedText);
            this.Name = "NotAuthorizedControl";
            this.Size = new System.Drawing.Size(1182, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotAuthorisedText;
        private System.Windows.Forms.LinkLabel SignInLink;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label PleaseLabel;
        private System.Windows.Forms.Label OrLabel;
    }
}
