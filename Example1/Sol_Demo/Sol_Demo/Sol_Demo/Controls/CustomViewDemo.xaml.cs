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
    public partial class CustomViewDemo : ContentView
    {
        public CustomViewDemo()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty CustomContentProperty =
            BindableProperty.Create(
                    propertyName: nameof(Content),
                    returnType: typeof(View),
                    declaringType: typeof(CustomViewDemo),
                    defaultBindingMode: BindingMode.OneWay,
                    propertyChanged: CustomContent_PropertyChanged
                );

        public View CustomContent
        {
            get => (View)base.GetValue(CustomContentProperty);
            set => base.SetValue(CustomContentProperty, value);
        }

        private static void CustomContent_PropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var selfControl = (CustomViewDemo)bindable;
            var value = (View)newValue;

            if (value != null)
            {
                selfControl.viewContent.Content = value as View;
            }
        }
    }
}