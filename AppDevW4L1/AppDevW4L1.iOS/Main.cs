using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Intents;
using UIKit;

namespace AppDevW4L1.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        public static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            
        }
    }
}
