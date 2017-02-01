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



namespace LoginSystem
{
    [Activity(Label = "LoginSystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Button mButtnSignup;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource  
            SetContentView(Resource.Layout.Main);

            mButtnSignup = FindViewById<Button>(Resource.Id.sinup);
            mButtnSignup.Click += (object sender, EventArgs args) =>
            {
                FragmentTransaction transcation = FragmentManager.BeginTransaction();
                Dialogclass signup = new Dialogclass();
                signup.Show(transcation, "Dialog Fragment");
            };


        }


    }
}