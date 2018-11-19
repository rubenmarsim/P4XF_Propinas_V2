using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Propinas
{
	public class MainView : ContentPage
	{
		public MainView ()
		{
            var lblHeader = new Label
            {
                Text = "Propinas Xamarin.Forms Ruben Martinez",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            var stackLayout = new StackLayout
            {
                Children =
                {
                    lblHeader
                }
            };
			Content = new ScrollView {
				Content = stackLayout
			};
		}
	}
}