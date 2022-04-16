﻿using Android.Content;
using CustomControls.Controls.Entrys;
using CustomControls.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryEyeliner), typeof(CustomEntryRenderer))]
namespace CustomControls.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context)
            : base(context)
        { 
        
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }
}