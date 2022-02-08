using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using AlertDialog = AndroidX.AppCompat.App.AlertDialog;

namespace Permission_Api
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _Button;
        private AlertDialog.Builder _builder;
        private ISharedPreferences _sharedPrefrences;
        private ISharedPreferencesEditor _editor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            UIReferences();
            UIClickEvents();
            InitializeSharedPreferences();
        }
        private void UIReferences()
        {
            _Button = FindViewById<Button>(Resource.Id.button1);
        }


        private void InitializeSharedPreferences()
        {
            throw new NotImplementedException();
        }

        private void UIClickEvents()
        {
            throw new NotImplementedException();
        }
    }
}

