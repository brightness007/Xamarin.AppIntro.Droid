using Android.App;
using Android.OS;
using Com.Github.Appintro;

namespace Example
{
    [Activity(Theme = "@style/AppIntroTheme")]
    class DefaultIntro : AppIntro
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AddSlide(AppIntroFragment.NewInstance(
                    "Welcome!",
                    "This is a demo of the AppIntro library, with a custom background on each slide!",
                    imageDrawable: Resource.Drawable.ic_slide1
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Clean App Intros",
                "This library offers developers the ability to add clean app intros at the start of their apps.",
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
