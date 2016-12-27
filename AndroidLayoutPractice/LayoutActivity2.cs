using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidLayoutPractice {
    [Activity(Label = "LayoutActivity2")]
    public class LayoutActivity2 : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_layout3);
            // Create your application here

            var btn1 = FindViewById<Button>(Resource.Id.button_layout1);
            btn1.Click += delegate {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            var btn2 = FindViewById<Button>(Resource.Id.button_layout2);
            btn2.Click += delegate {
                var intent = new Intent(this, typeof(LayoutActivity1));
                StartActivity(intent);
            };
        }
    }
}