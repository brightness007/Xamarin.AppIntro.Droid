using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System.Collections.Generic;

namespace Example
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppIntroTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var defaultEntries = new List<IntroEntry>()
            {
                new IntroEntry(Resource.String.default_intro_title, Resource.String.default_intro, typeof(DefaultIntro)),
                new IntroEntry(Resource.String.default_intro2_title, Resource.String.default_intro2, typeof(DefaultIntro2)),
                new IntroEntry(Resource.String.custom_layout_intro_title, Resource.String.custom_layout_intro, typeof(CustomLayoutIntro)),
                new IntroEntry(Resource.String.custom_background_intro_title, Resource.String.custom_background_intro, typeof(CustomBackgroundIntro)),
                new IntroEntry(Resource.String.perms_intro1_title, Resource.String.perms_intro1, typeof(PermissionsIntro)),
                new IntroEntry(Resource.String.perms_intro2_title, Resource.String.perms_intro2, typeof(PermissionsIntro2))
            };

            var viewManager = new LinearLayoutManager(this);
            var viewAdapter = new IntroAdapter(defaultEntries);

            var view = FindViewById<RecyclerView>(Resource.Id.main_recycler_view);
            view.HasFixedSize = true;
            view.SetLayoutManager(viewManager);
            view.SetAdapter(viewAdapter);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
