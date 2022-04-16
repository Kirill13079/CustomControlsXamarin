using Xamarin.Forms;

namespace CustomControls.Controls.Entrys.Behaviors
{
    public class EntryEyelinerBackgroundBehavior : Behavior<EntryEyeliner>
    {
        protected override void OnAttachedTo(EntryEyeliner bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += Bindable_Background;
        }

        protected override void OnDetachingFrom(EntryEyeliner bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= Bindable_Background;
        }

        private void Bindable_Background(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length == 0)
            {
                ((EntryEyeliner)sender).BackgroundColor = Color.Red;
            }
            else 
            {
                ((EntryEyeliner)sender).BackgroundColor = Color.Transparent;
            }
        }
    }
}
