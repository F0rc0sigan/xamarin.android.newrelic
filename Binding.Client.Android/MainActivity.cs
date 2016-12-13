using Android.App;
using Android.Widget;
using Android.OS;
using Com.Newrelic.Agent.Android;

namespace Binidng.Client.Android
{
    [Activity(Label = "Binidng.Client.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            //NewRelicHelper.withApplicationToken("").start(this.Application);
            //NewRelicHelper - is not available
            //NewRelic - is not available
            // How to initialize newrelic?
        }
    }
}

