using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlSamples
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
        }

        async void OnPlusCodeBtnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new XamlPlusCodePage());
        }
    }
}
