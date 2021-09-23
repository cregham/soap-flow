using automation.Core;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace automation.Drivers
{
    public class MainWindow : UserInterfaceObject
    {
        public Button GetUsers => Button("GetUsersButton");
        public ListBox ClientListBox => ListBox("ClientListBox");
        public MainWindow(Window page) : base(page)
        {
        }

        public void ClickGetUsers()
        {
            GetUsers.Click();
        }

        public int CheckUserCount()
        {
            return ClientListBox.Items.Count;
        }
    }
}
