using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : ContentView
    {
        public CardView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create
                (nameof(BorderColor),
                typeof(Color),
                typeof(CardView),
                Color.DarkGray);

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static readonly BindableProperty CardColorProperty =
                BindableProperty.Create(
                        nameof(CardColor),
                        typeof(Color),
                        typeof(CardView),
                        Color.White);

        public Color CardColor
        {
            get => (Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }

        public static readonly BindableProperty ViewContentProperty =
           BindableProperty.Create(
                   propertyName: nameof(Content),
                   returnType: typeof(View),
                   declaringType: typeof(CardView),
                   defaultBindingMode: BindingMode.OneWay,
                   propertyChanged: CustomContent_PropertyChanged
               );

        public View ViewContent
        {
            get => (View)base.GetValue(ViewContentProperty);
            set => base.SetValue(ViewContentProperty, value);
        }

        private static void CustomContent_PropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var selfControl = (CardView)bindable;
            var value = (View)newValue;

            if (value != null)
            {
                selfControl.viewContent.Content = value as View;
            }
        }
    }
}