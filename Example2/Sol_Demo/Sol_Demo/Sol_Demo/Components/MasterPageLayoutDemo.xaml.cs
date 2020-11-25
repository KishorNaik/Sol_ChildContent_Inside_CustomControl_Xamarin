using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageLayoutDemo : ContentView
    {
        public MasterPageLayoutDemo()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty MasterLayoutContentProperty =
        BindableProperty.Create(nameof(MasterLayoutContent), typeof(View), typeof(MasterPageLayoutDemo));

        public View MasterLayoutContent
        {
            get { return (View)GetValue(MasterLayoutContentProperty); }
            set { SetValue(MasterLayoutContentProperty, value); }
        }
    }
}