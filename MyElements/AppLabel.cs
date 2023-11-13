using MyFramework.MyApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace MyFramework.MyElements
{
    public class AppLabel : AppBaseItem
    {
        public AppLabel(AppWindow appWindow, string automationId) : base(GetLabelByAutomationId(appWindow, automationId))
        {
        }
        private static Label GetLabelByAutomationId(AppWindow appWindow, string automationId)
        {
            //use search criteria .byAutomationId to find the label by it's automationId
            return appWindow.Get<Label>(SearchCriteria.ByAutomationId(automationId));
        }

        public string GetText()
        {
            return ((Label)uiItem).Text;
        }

    }
}
