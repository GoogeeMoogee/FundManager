﻿using System.Windows.Forms;

namespace FundManager.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.HeaderPanel.Controls.Add(new NotAuthorizedControl());
        }
    }
}
