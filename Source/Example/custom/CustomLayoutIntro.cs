using Android.App;
using Android.OS;
using Com.Github.Appintro;

namespace Example
{
    [Activity(Theme = "@style/AppIntroTheme")]
    class CustomLayoutIntro : AppIntro
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AddSlide(AppIntroCustomLayoutFragment.NewInstance(Resource.Layout.intro_custom_layout1));
            AddSlide(AppIntroCustomLayoutFragment.NewInstance(Resource.Layout.intro_custom_layout2));
            AddSlide(AppIntroCustomLayoutFragment.NewInstance(Resource.Layout.intro_custom_layout3));
            AddSlide(AppIntroCustomLayoutFragment.NewInstance(Resource.Layout.intro_custom_layout4));

            ShowStatusBar(true);
            SetStatusBarColorRes(Resource.Color.orange);
            SetNavBarColorRes(Resource.Color.orange);
            SetProgressIndicator();
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
