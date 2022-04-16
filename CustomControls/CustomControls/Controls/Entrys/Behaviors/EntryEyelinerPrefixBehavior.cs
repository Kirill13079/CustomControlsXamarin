using Xamarin.Forms;

namespace CustomControls.Controls.Entrys.Behaviors
{
    public  class EntryEyelinerPrefixBehavior : Behavior<EntryEyeliner>
    {
        public static readonly BindableProperty PrefixProperty 
            = BindableProperty.Create(
                nameof(Prefix),
                typeof(string),
                typeof(EntryEyeliner),
                "+");

        public string Prefix
        {
            get => (string)GetValue(PrefixProperty);
            set => SetValue(PrefixProperty, value);
        }

        protected override void OnAttachedTo(EntryEyeliner bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += Bindable_TextChanged;
        }

        protected override void OnDetachingFrom(EntryEyeliner bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue)
                && !e.NewTextValue.StartsWith(Prefix))
            {
                ((EntryEyeliner)sender).Text = $"{Prefix} {e.NewTextValue}";
            }
        }
    }
}
