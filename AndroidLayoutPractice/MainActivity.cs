using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace AndroidLayoutPractice {
    [Activity(Label = "AndroidLayoutPractice", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_layout1);

            var btn1 = FindViewById<Button>(Resource.Id.button_layout1);
            btn1.Click += delegate {
                var intent = new Intent(this, typeof(LayoutActivity1));
                StartActivity(intent);
            };

            var btn2 = FindViewById<Button>(Resource.Id.button_layout2);
            btn2.Click += delegate {
                var intent = new Intent(this, typeof(LayoutActivity2));
                StartActivity(intent);
            };
        }
    }
}