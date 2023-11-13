using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.MenuItems;
using MyFramework.MyApplication;

namespace MyFramework.MyElements
{
    public class AppBaseItem
    {
        protected UIItem uiItem;
        private Button button;
        private Label label;
        private Menu menu;
        private AppWindow appWindow;
        private SearchCriteria searchCriteria;

        public AppBaseItem(MyApplication.AppWindow calculatorWindow, UIItem uiItem)
        {
            this.appWindow = appWindow;
            this.uiItem = uiItem;
        }

        public AppBaseItem(Button button)
        {
            this.button = button;
        }

        public AppBaseItem(Label label)
        {
            this.label = label;
        }

        public AppBaseItem(Menu menu)
        {
            this.menu = menu;
        }

        public AppBaseItem(AppWindow appWindow)
        {
            this.appWindow = appWindow;
        }

        public AppBaseItem(AppWindow appWindow, SearchCriteria searchCriteria) : this(appWindow)
        {
            this.searchCriteria = searchCriteria;
        }


        //Method to retrieve the UIElement
        public IUIItem UIGetElement()
        {
            return uiItem;
        }

        //Method to perform single click on the UI Element

        public void Click()
        {
            uiItem.Click();
        }

        //Method to perform DoubleClick on the UIelement

        public void DoubleClick()
        {
            uiItem.DoubleClick();
        }
    }
}

