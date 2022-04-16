using Xamarin.Forms;

namespace CustomControls.Controls.Entrys.Triggers
{
    public class EntryEyelinerFocusTrigger : TriggerAction<EntryEyeliner>
    {
        protected override void Invoke(EntryEyeliner sender)
        {
            sender.BackgroundColor = Color.LightGray;
        }
    }
}
