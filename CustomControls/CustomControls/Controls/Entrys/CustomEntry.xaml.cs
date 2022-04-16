using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControls.Controls.Entrys
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntry : ContentView
    {
        public CustomEntry()
        {
            InitializeComponent();

            TitleEntry.Text = TitleEntr;
            TextEntry.Text = TextEntr;

            TextEntry.TextChanged += TextEntry_TextChanged;
        }

        public static readonly BindableProperty TitleProperty
            = BindableProperty.Create(
                nameof(TitleEntry),
                typeof(string),
                typeof(CustomEntry),
                default(string),
                BindingMode.OneWay);


        public static readonly BindableProperty TextProperty
            = BindableProperty.Create(
                nameof(TextEntry),
                typeof(string),
                typeof(CustomEntry),
                default(string),
                BindingMode.TwoWay);

        public string TextEntr
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string TitleEntr
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        protected override void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextProperty.PropertyName)
            {
                TitleEntry.Text = TitleEntr;
            }
            else if (propertyName == TitleProperty.PropertyName)
            {
                TextEntry.Text = TextEntr;
            }
        }

        private void TextEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextEntr = e.NewTextValue;
        }
    }
}