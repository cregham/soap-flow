using System;
using System.ServiceModel;
using System.Windows.Forms;
using ui.Core;
using ui.SpecFlowSOAP;

namespace ui
{
    public partial class UserForm : Form
    {
        private readonly UserDataProvider _userProvider;

        public UserForm()
        {
            InitializeComponent();
            _userProvider = new UserDataProvider();
            GetUsers();
            SaveChangesButton.Enabled = false;
            AddUserButton.Enabled = true;
        }

        private void GetUsers()
        {
            UserListBox.Items.Clear();
            ClearFields();
            try
            {
                foreach (var user in _userProvider.GetUsers())
                {
                    UserListBox.Items.Add(user);
                }
            }
            catch (Exception)
            {
                AddError("Could not contact service. Is it running?");
            }
        }

        private void AddUserButton_Click(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                AddError("Name Required");
                return;
            }

            var user = new User()
            {
                Name = NameTextBox.Text,
                Age = Convert.ToInt32(AgeNumericUpDown.Value),
            };

            try
            {
                _userProvider.AddUser(user);
            }
            catch (FaultException<GenericFault> e)
            {
                AddError(e.Detail.Message, e.Detail.ResponseCode);
            }

            GetUsers();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (!(UserListBox.SelectedItem is User selectedUser))
            {
                AddError("Select a user to save changes");
                return;
            }

            _userProvider.SetName(selectedUser.Id, NameTextBox.Text);
            _userProvider.SetAge(selectedUser.Id, int.Parse(AgeNumericUpDown.Text));

            var index = UserListBox.SelectedIndex;
            GetUsers();
            UserListBox.SelectedIndex = index;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (!(UserListBox.SelectedItem is User selectedUser))
            {
                AddError("To delete a user select one from the list");
                return;
            }
            _userProvider.RemoveUser(selectedUser.Id);
            GetUsers();
        }

        private void ClearSelectionButton_Click(object sender, EventArgs e)
        {
            UserListBox.ClearSelected();
            AddUserButton.Enabled = true;
            SelectedUserLabel.Enabled = false;
            ClearSelectionButton.Enabled = false;
        }

        private void UserListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var user = ((User)e.ListItem);
            e.Value = string.Format("ID: {0} | Name: {1} | Age: {2}", user.Id, user.Name, user.Age);
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = UserListBox.SelectedItem as User;
            if (selectedUser == null)
            {
                ClearFields();
                SaveChangesButton.Enabled = false;
                AddUserButton.Enabled = true;
                ClearSelectionButton.Enabled = false;
            }
            else
            {
                IDTextBox.Text = selectedUser.Id.ToString();
                NameTextBox.Text = selectedUser.Name;
                AgeNumericUpDown.Text = selectedUser.Age.ToString();

                SaveChangesButton.Enabled = true;
                AddUserButton.Enabled = false;
                ClearSelectionButton.Enabled = true;
            }
        }

        private void ClearFields()
        {
            IDTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            AgeNumericUpDown.Text = string.Empty;
        }

        private void AddError(string error, int responseCode = 0)
        {
            if (responseCode != 0)
            {
                Errors.Text += $"HTTP Error Code: {responseCode}\r\n";
            }
       
            Errors.Text += $"{error}\r\n\r\n";
        }
    }
}
