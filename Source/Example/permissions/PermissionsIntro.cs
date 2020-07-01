using Android;
using Android.App;
using Android.OS;
using Com.Github.Appintro;

namespace Example
{
    [Activity(Theme = "@style/AppIntroTheme")]
    class PermissionsIntro : AppIntro
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AddSlide(AppIntroFragment.NewInstance(
                "Welcome!",
                "This is a demo of the AppIntro library, with permissions being requested on a slide!",
                imageDrawable: Resource.Drawable.ic_slide1
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Permission Request",
                "In order to access your camera, you must give permissions.",
                imageDrawable: Resource.Drawable.ic_slide2
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Simple, yet Customizable",
                "The library offers a lot of customization, while keeping it simple for those that like simple.",
                imageDrawable: Resource.Drawable.ic_slide3
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Explore",
                "Feel free to explore the rest of the library demo!",
                imageDrawable: Resource.Drawable.ic_slide4
            ));

            // Here we ask for camera permission on slide 2
            AskForPermissions(new string[] { Manifest.Permission.Camera }, 2);
        }

        protected override void OnSkipPressed(AndroidX.Fragment.App.Fragment currentFragment)
        {
            base.OnSkipPressed(currentFragment);
            Finish();
        }

        protected override void OnDonePressed(AndroidX.Fragment.App.Fragment currentFragment)
        {
            base.OnDonePressed(currentFragment);
            Finish();
        }
    }
}
