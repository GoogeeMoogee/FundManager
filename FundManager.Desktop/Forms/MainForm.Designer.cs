namespace FundManager.Desktop.Forms
{
    partial class MainForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MenuList = new System.Windows.Forms.ListBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 96);
            this.HeaderPanel.TabIndex = 0;
            // 
            // MenuList
            // 
            this.MenuList.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuList.FormattingEnabled = true;
            this.MenuList.Location = new System.Drawing.Point(0, 96);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(120, 393);
            this.MenuList.TabIndex = 1;
            this.MenuList.SelectedValueChanged += new System.EventHandler(this.MenuList_SelectedValueChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(120, 96);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(680, 393);
            this.MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuList);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.ListBox MenuList;
        private System.Windows.Forms.Panel MainPanel;
    }
}