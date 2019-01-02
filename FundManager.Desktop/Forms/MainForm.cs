using System;
using System.Windows.Forms;
using FundManager.Core.Component;
using FundManager.Desktop.Controls;
using FundManager.Desktop.Enums;

namespace FundManager.Desktop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateMenu();
            var user = GlobalSession.GetDesktopCurrentUser();
            ChangeHeader(user != null);
        }

        public void ChangeHeader(bool isAuthorized)
        {
            HeaderPanel.Controls.Clear();
            if (isAuthorized)
            {
                HeaderPanel.Controls.Add(new AuthorizedControl());
            }
            else
            {
                HeaderPanel.Controls.Add(new NotAuthorizedControl());
            }
        }

        private void CreateMenu()
        {
            foreach (var menuItem in Enum.GetValues(typeof(MenuItemEnum)))
            {
                MenuList.Items.Add(menuItem);
            }
        }

        private void MenuList_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentMenuItem = (MenuItemEnum)MenuList.SelectedItem;
            switch (currentMenuItem)
            {
                  case MenuItemEnum.Spendings:
                      MainPanel.Controls.Clear();
                      MainPanel.Controls.Add(new SpendingsControl());
                      break;
                  case MenuItemEnum.Calendar:
                      MainPanel.Controls.Clear();
                      MainPanel.Controls.Add(new CalendarControl());
                      break;
            }
        }
    }
}
