using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Nio.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModiMeet
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        Button login;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LoginLayout);

            login = FindViewById<Button>(Resource.Id.log);
            login.Click += Login_Click;
        }

        //צריך להוסיף בדיקת תקינות
        private void Login_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainPage));
            StartActivity(intent);
        }
    }
}