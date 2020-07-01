namespace Com.Github.Appintro
{
    public abstract partial class AppIntro2
    {
		public int? BackgroundResource
        {
			get => _getBackgroundResource()?.IntValue();
			set
			{
				if (value != null)
                {
					_setBackgroundResource(new Java.Lang.Integer((int)value));
				}
				else
                {
					_setBackgroundResource(null);
				}
			}
		}
	}
}
