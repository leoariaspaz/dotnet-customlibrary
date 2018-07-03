using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLibrary.ComponentModel
{
    public class NumericTextBox : TextBox
    {
        private int _digits;
        private string _decimalSeparator;

        public NumericTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
            _digits = 0;
            _decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }

        [DefaultValue(0)]
        [Description("Cantidad de dígitos decimales.")]
        public int Digits
        {
            get
            {
                return _digits;
            }
            set
            {
                _digits = (value >= 0) ? value : 0;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            var esSeparador = e.KeyChar == '.' || e.KeyChar == ',';
            if (!Char.IsDigit(e.KeyChar) && !esSeparador && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (esSeparador)
            {
                if (Digits == 0)
                {
                    e.Handled = true;
                }
                else
                    if (this.Text.Contains(_decimalSeparator))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.KeyChar = _decimalSeparator.FirstOrDefault();
                    }
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            decimal d = 0;
            if (Decimal.TryParse(this.Text, out d))
            {
                string format = "{0:n" + Digits + "}";
                this.Text = String.Format(format, d);
            }
        }

        public Int64 IntValue
        {
            get
            {
                return Convert.ToInt64(DecValue);
            }
        }

        public Decimal DecValue
        {
            get
            {
                Decimal result = 0;
                Decimal.TryParse(this.Text, out result);
                return result;
            }
        }
    }
}
