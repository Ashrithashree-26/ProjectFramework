using System;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using MyFramework.MyApplication;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace MyFramework.MyElements
{
    public  class AppButtons : AppBaseItem
    {
        public AppButtons(Button button) : base(button)
        {

        }
        //Overloading constructor to initialize Appbutton with automation id
        public AppButtons(AppWindow appWindow, string automationId) : base(GetButtonByAutomationId(appWindow, automationId))
        {

        }

        public static Button GetButtonByAutomationId(AppWindow appWindow, string automationId)
        {
            var button = appWindow.Get<Button>(SearchCriteria.ByAutomationId(automationId));

            if (button == null)
            {
                throw new ArgumentException($"Button with automationid '{automationId}' not found");
            }

            return button;
        }

        /*public void SelectMode(string mode) 
        {
            var modeButton = GetButtonByAutomationId(appWindow, mode + "ModeButtonId");
            modeButton.Click();
        }*/
    }

}

