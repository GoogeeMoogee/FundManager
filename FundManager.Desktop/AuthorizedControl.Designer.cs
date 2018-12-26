namespace FundManager.Desktop
{
    partial class AuthorizedControl
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
            this.AuthorizedText = new System.Windows.Forms.Label();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AuthorizedText
            // 
            this.AuthorizedText.AutoSize = true;
            this.AuthorizedText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizedText.Location = new System.Drawing.Point(28, 11);
            this.AuthorizedText.Name = "AuthorizedText";
            this.AuthorizedText.Size = new System.Drawing.Size(299, 23);
            this.AuthorizedText.TabIndex = 0;
            this.AuthorizedText.Text = "Currently, you are logged in as {0}";
            // 
            // LogOutLink
            // 
            this.LogOutLink.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.LogOutLink.Location = new System.Drawing.Point(28, 44);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(75, 23);
            this.LogOutLink.TabIndex = 1;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "LogOut";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // AuthorizedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.AuthorizedText);
            this.Name = "AuthorizedControl";
            this.Size = new System.Drawing.Size(1182, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorizedText;
        private System.Windows.Forms.LinkLabel LogOutLink;
    }
}
