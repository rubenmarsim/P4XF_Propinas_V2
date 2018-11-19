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
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            var lblSubtotal = new Label
            {
                Text = "Subtotal:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Fill
            };
            var edtrSubtotal = new Editor
            {
                HorizontalOptions = LayoutOptions.Fill
            };
            var lblPostTax = new Label
            {
                Text = "Total (Post-Tax):",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Fill
            };
            var edtrPostTax = new Editor
            {
                HorizontalOptions = LayoutOptions.Fill
            };
            var lblTipPercent = new Label
            {
                Text = "Tip Percent:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Fill
            };
            var edtrTipPercent = new Editor
            {
                HorizontalOptions = LayoutOptions.Fill,
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
                HorizontalOptions = LayoutOptions.Fill
            };
            var edtrTipValue = new Editor
            {
                HorizontalOptions = LayoutOptions.Fill,
                IsEnabled = false,
            };
            var lblTotal = new Label
            {
                Text = "Total:",
                FontSize = 10,
                FontAttributes = FontAttributes.None,
                HorizontalOptions = LayoutOptions.Fill
            };
            var edtrTotal = new Editor
            {
                HorizontalOptions = LayoutOptions.Fill,
                IsEnabled = false,               
            };
            var btnCalcular = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Calculate",
            };

            var stackLayout = new StackLayout
            {
                Children =
                {
                    lblHeader, lblSubtotal, edtrSubtotal, lblPostTax, edtrPostTax,
                    lblTipPercent, edtrTipPercent, lblTipValue, edtrTipPercent,
                    sldr, lblTipValue, edtrTipValue, lblTotal, edtrTotal, btnCalcular
                }
            };
			Content = new ScrollView {
				Content = stackLayout
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
            #endregion

        }
    }
}