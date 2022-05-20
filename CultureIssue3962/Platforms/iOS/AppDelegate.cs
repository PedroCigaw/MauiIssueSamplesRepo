using System.Diagnostics;
using System.Globalization;
using Foundation;
using UIKit;

namespace CurrentCultureSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp()
    {
        //uncommenting this code throws and exception

        //var culture = CultureInfo.CreateSpecificCulture(NSLocale.CurrentLocale.CollationIdentifier);
        //CultureInfo.DefaultThreadCurrentCulture = culture;
        //CultureInfo.DefaultThreadCurrentUICulture = culture;
       
        return MauiProgram.CreateMauiApp();
    }

    public override bool WillFinishLaunching(UIApplication application, NSDictionary launchOptions)
    {
        //uncommenting this code throws and exception

        //var culture = CultureInfo.CreateSpecificCulture(NSLocale.CurrentLocale.CollationIdentifier);
        //CultureInfo.DefaultThreadCurrentCulture = culture;
        //CultureInfo.DefaultThreadCurrentUICulture = culture;
        return base.WillFinishLaunching(application, launchOptions);
    }

    
    public override void OnActivated(UIApplication application)
    {
        //uncommenting this code throws and exception

        //var culture = CultureInfo.CreateSpecificCulture(NSLocale.CurrentLocale.CollationIdentifier);
        //CultureInfo.DefaultThreadCurrentCulture = culture;
        //CultureInfo.DefaultThreadCurrentUICulture = culture;

        base.OnActivated(application);
    }
}
