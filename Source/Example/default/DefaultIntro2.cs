using Android.App;
using Android.OS;
using Com.Github.Appintro;
using Com.Github.Appintro.Model;

namespace Example
{
    [Activity(Theme = "@style/AppIntroTheme")]
    class DefaultIntro2 : AppIntro2
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AddSlide(AppIntroFragment.NewInstance(
                "Welcome!",
                "This is a demo of the AppIntro library, using the second layout.",
                imageDrawable: Resource.Drawable.ic_slide1,
                backgroundDrawable: Resource.Drawable.back_slide1,
                titleTypefaceFontRes: Resource.Font.lato,
                descriptionTypefaceFontRes: Resource.Font.lato
            ));

            AddSlide(AppIntroFragment.NewInstance(new SliderPage(
                "Gradients!",
                "This text is written on a gradient background",
                imageDrawable: Resource.Drawable.ic_slide2,
                backgroundDrawable: Resource.Drawable.back_slide2,
                titleTypeface: "OpenSans-Light.ttf",
                descriptionTypeface: "OpenSans-Light.ttf"
            )));

            AddSlide(AppIntroFragment.NewInstance(
                "Simple, yet Customizable",
                "The library offers a lot of customization, while keeping it simple for those that like simple.",
                imageDrawable: Resource.Drawable.ic_slide3,
                backgroundDrawable: Resource.Drawable.back_slide3,
                titleTypefaceFontRes: Resource.Font.opensans_regular,
                descriptionTypefaceFontRes: Resource.Font.opensans_regular
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Explore",
                "Feel free to explore the rest of the library demo!",
                imageDrawable: Resource.Drawable.ic_slide4,
                backgroundDrawable: Resource.Drawable.back_slide4
            ));

            AddSlide(AppIntroFragment.NewInstance(
                ":)",
                "...gradients are awesome!",
                imageDrawable: Resource.Mipmap.ic_launcher,
                backgroundDrawable: Resource.Drawable.back_slide5
            ));

            SetTransformer(new AppIntroPageTransformerType.Parallax());
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
