using System;
using TestStack.White;
using TestStack.White.Factory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFramework;

namespace MyFramework.MyApplication
{
    public class AppManager
    {
        static Application application;
        //Method for Launching an application using it's path

        public void LaunchApp(string applicationPath)
        {
            application = Application.Launch(applicationPath);
        }

        //Method to get the application main window

        public AppWindow GetMainWindow(string windowTitle)
        {
            var Window = application.GetWindow(windowTitle, InitializeOption.NoCache);
            return new AppWindow(Window);
        }

        //Method to Close Application

        public void CloseApp()
        {
            application.Close();
        }
    }
}

