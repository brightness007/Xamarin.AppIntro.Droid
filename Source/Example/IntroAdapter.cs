using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System.Collections.Generic;

namespace Example
{
    class IntroAdapter : RecyclerView.Adapter
    {
        private List<IntroEntry> entries;

        public IntroAdapter(List<IntroEntry> entries)
        {
            this.entries = entries;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var root = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_intro, parent, false);
            return new IntroAdapterViewHolder(root);
        }

        public override int ItemCount => entries.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is IntroAdapterViewHolder item)
            {
                item.Bind(entries[position]);
            }
        }

        internal class IntroAdapterViewHolder : RecyclerView.ViewHolder
        {
            private View root;
            private TextView title;
            private TextView description;
            private TextView button;

            public IntroAdapterViewHolder(View root) : base(root)
            {
                this.root = root;
                title = (TextView)root.FindViewById(Resource.Id.item_title);
                description = (TextView)root.FindViewById(Resource.Id.item_description);
                button = (TextView)root.FindViewById(Resource.Id.item_button);
            }

            public void Bind(IntroEntry entry)
            {
                title.SetText(entry.title);
                description.SetText(entry.description);
                button.Click += (s, e) =>
                {
                    var intent = new Intent(root.Context, entry.activityClass);
                    root.Context.StartActivity(intent);
                };
            }
        }
    }
}
