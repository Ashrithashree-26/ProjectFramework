using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;

namespace MyFramework.MyApplication
{
    public class AppWindow
    {
        private readonly Window window;


        //giving constructor to Initialize the AppWindow with a specific Window instance
        public AppWindow(Window window)
        {
            this.window = window;
        }
        //As part of Potential fixes
        public T Get<T>(SearchCriteria searchCriteria) where T : UIItem
        {
            return window.Get<T>(searchCriteria);
        }

        public Button GetButtonByAutomationId(string automationId)
        {
            return window.Get<Button>(SearchCriteria.ByAutomationId(automationId));
        }

        public T Get<T>(string automationId) where T : UIItem
        {
            var searchCriteria = SearchCriteria.ByAutomationId(automationId);
            return window.Get<T>(searchCriteria);
        }
    }
}

