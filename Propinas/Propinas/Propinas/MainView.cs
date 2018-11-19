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
            #region Layout
            var lblHeader = new Label
            {
                Text = "Propinas Xamarin.Forms Ruben Martinez",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center

            };
            var lblSubtotal = new Label
            {
                Text = "Subtotal:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            var edtrSubtotal = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var lblPostTax = new Label
            {
                Text = "Total (Post-Tax):",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            var edtrPostTax = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var lblTipPercent = new Label
            {
                Text = "Tip Percent:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            var edtrTipPercent = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                IsEnabled = false,
            };
            var sldr = new Slider
            {
                Minimum = 0,
                Maximum = 100,
            };
            var lblTipValue = new Label
            {
                Text = "Tip Value:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            var edtrTipValue = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                IsEnabled = false,
            };
            var lblTotal = new Label
            {
                Text = "Total:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            var edtrTotal = new Editor
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                IsEnabled = false,               
            };
            var btnCalcular = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Calculate",
                FontSize = 10,
            };

            var grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition{Height = GridLength.Auto},
                    new RowDefinition{Height=GridLength.Auto},
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Auto)},
                    new RowDefinition{Height=new GridLength(100, GridUnitType.Absolute)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=GridLength.Auto },
                    new ColumnDefinition{Width=new GridLength(2,GridUnitType.Auto)},
                    new ColumnDefinition{Width=new GridLength(100,GridUnitType.Absolute)}
                },
            };
            grid.Children.Add(lblHeader,1,0);
            grid.Children.Add(btnCalcular, 2, 0);
            grid.Children.Add(lblSubtotal,1,1);
            grid.Children.Add(edtrSubtotal, 2,1);
            grid.Children.Add(lblPostTax, 1, 2);
            grid.Children.Add(edtrPostTax, 2, 2);
            grid.Children.Add(lblTipPercent, 1, 3);
            grid.Children.Add(edtrTipPercent, 2, 3);
            grid.Children.Add(sldr,1,2,4,5);
            grid.Children.Add(lblTipValue, 1, 5);
            grid.Children.Add(edtrTipValue, 2, 5);
            grid.Children.Add(lblTotal, 1, 6);
            grid.Children.Add(edtrTotal, 2, 6);

            Content = new ScrollView {
				Content = grid
			};
            #endregion

            #region Instancias
            var CTipInfo = new TipInfo();
            #endregion

            #region Metodos
            btnCalcular.Clicked += (sender, e) =>
            {
                CTipInfo.Subtotal = double.Parse(edtrSubtotal.Text);
                CTipInfo.PostTax = double.Parse(edtrPostTax.Text);
                CTipInfo.sldrVal = sldr.Value;
                CTipInfo.Calculos();
                edtrTipPercent.Text = CTipInfo.TipPercent.ToString();
                edtrTipValue.Text = CTipInfo.TipValue.ToString();
                edtrTotal.Text = CTipInfo.Total.ToString();
            };
            edtrPostTax.Unfocused += (sender, e) =>
            {
                CTipInfo.Subtotal = double.Parse(edtrSubtotal.Text);
                CTipInfo.PostTax = double.Parse(edtrPostTax.Text);
                CTipInfo.sldrVal = sldr.Value;
                CTipInfo.Calculos();
                edtrTipPercent.Text = CTipInfo.TipPercent.ToString();
                edtrTipValue.Text = CTipInfo.TipValue.ToString();
                edtrTotal.Text = CTipInfo.Total.ToString();
            };
            sldr.ValueChanged += (sender, e) =>
            {
                CTipInfo.Subtotal = double.Parse(edtrSubtotal.Text);
                CTipInfo.PostTax = double.Parse(edtrPostTax.Text);
                CTipInfo.sldrVal = sldr.Value;
                CTipInfo.Calculos();
                edtrTipPercent.Text = CTipInfo.TipPercent.ToString();
                edtrTipValue.Text = CTipInfo.TipValue.ToString();
                edtrTotal.Text = CTipInfo.Total.ToString();
            };
            #endregion

        }
    }
}