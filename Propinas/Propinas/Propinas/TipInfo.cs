using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Propinas
{
    public class TipInfo
    {
        private double _Subtotal;

        public double Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        private double _PostTax;

        public double PostTax
        {
            get { return _PostTax; }
            set { _PostTax = value; }
        }

        private double _TipPercent;

        public double TipPercent
        {
            get { return _TipPercent; }
            set { _TipPercent = value; }
        }

        private double _TipValue;

        public double TipValue
        {
            get { return _TipValue; }
            set { _TipValue = value; }
        }

        private double _Total;

        public double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public void Calculos()
        {
            TipValue = PostTax * TipPercent / 100;
            Total = TipValue + PostTax;
        }

    }
}
