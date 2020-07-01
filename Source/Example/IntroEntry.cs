using System;

namespace Example
{
    class IntroEntry
    {
        public int title;
        public int description;
        public Type activityClass;

        public IntroEntry(int title, int description, Type activityClass)
        {
            this.title = title;
            this.description = description;
            this.activityClass = activityClass;
        }
    }
}
