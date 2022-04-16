using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControls.Controls.Buttons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DownloadButton : ContentView
    {
        public DownloadButton()
        {
            InitializeComponent();

            DownloadBtn.Background = ColorBtn;
            DownloadBtnTxt.Text = TextBtn;
            DownloadBtnImg.Source = ImageBtn;
        }

        public static readonly BindableProperty ColorProperty
            = BindableProperty.Create(
                nameof(ColorBtn),
                typeof(Color),
                typeof(DownloadButton),
                default(Color),
                BindingMode.OneWay);

        public static readonly BindableProperty TextProperty
            = BindableProperty.Create(
                nameof(TextBtn),
                typeof(string),
                typeof(DownloadButton),
                default(string),
                BindingMode.OneWay);

        public static readonly BindableProperty ImageProperty
            = BindableProperty.Create(
                nameof(ImageBtn),
                typeof(string),
                typeof(DownloadButton),
                default(string),
                BindingMode.OneWay);

        public Color ColorBtn 
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public string TextBtn 
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value); 
        }

        public string ImageBtn
        {
            get => (string)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        protected override void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TextProperty.PropertyName)
            {
                DownloadBtnTxt.Text = TextBtn;
            }
            else if (propertyName == ColorProperty.PropertyName)
            {
                DownloadBtn.Background = ColorBtn;
            }
            else if (propertyName == ImageProperty.PropertyName)
            {
                DownloadBtnImg.Source = ImageBtn;
            }
        }
    }
}