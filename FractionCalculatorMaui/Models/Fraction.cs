using FractionCalculatorMaui.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorMaui.Models
{
    public class Fraction
    {
        public int whole;
        public int top;
        public int bottom;
        public Fraction() { }
        public Fraction(int _whole, int _top, int _bottom)
        {
            whole = _whole;
            top = _top;
            bottom = _bottom;
        }

        public decimal GetAsDecimal()
        {
            decimal result = 0;
            if (this.top > 0)
            {
                result = ((decimal)this.top / (decimal)this.bottom) + (decimal)this.whole;
            }
            return result;
        }
    }
}
