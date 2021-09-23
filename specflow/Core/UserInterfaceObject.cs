using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WPFUIItems;

namespace automation.Core
{
    public abstract class UserInterfaceObject
        {
            protected readonly UIItem Page;

            protected UserInterfaceObject(UIItem page)
            {
                Page = page;
            }

            protected Button Button(string title)
            {
                return Page.Get(SearchCriteria.ByAutomationId(title)) as Button;
            }

            protected ListBox ListBox(string name)
            {
                return Page.Get<ListBox>(SearchCriteria.ByAutomationId(name));
            }
        }
}
