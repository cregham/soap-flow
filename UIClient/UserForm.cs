using System;
using System.Windows.Forms;
using UserClient.Core;

namespace UserClient
{
    public partial class UserForm : Form
    {
        private readonly UserDataProvider _userProvider;

        public UserForm()
        {
            InitializeComponent();
            _userProvider = new UserDataProvider();
        }

        private void GetUsersButton_Click(object sender, EventArgs e)
        {
            ManualErrorLabel.Text = string.Empty;
            try
            {
                foreach (var user in _userProvider.GetUsersManual())
                {
                    ManualListBox.DisplayMember = "Name";
                    ManualListBox.Items.Add(user);
                }
            }
            catch (Exception)
            {
                ManualErrorLabel.Text = "Could not manually retrieve users using XML envelope.";
            }

            try
            {
                foreach (var user in _userProvider.GetUsersClient())
                {
                    ClientListBox.DisplayMember = "Name";
                    ClientListBox.Items.Add(user);
                }
            }
            catch (Exception)
            {
                ClientErrorLabel.Text = "Could not retrieve users using WSDF client.";
            }
        }
    }
}
