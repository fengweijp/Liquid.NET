﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liquid.NET.Constants;

namespace Liquid.NET.Filters.Strings
{
    /// <summary>
    /// https://docs.shopify.com/themes/liquid-documentation/filters/string-filters#pluralize
    /// </summary>
    public class PluralizeFilter : FilterExpression<NumericValue, StringValue>
    {
        private readonly StringValue _single;
        private readonly StringValue _plural;

        public PluralizeFilter(StringValue single, StringValue plural)
        {
            _single = single;
            _plural = plural;
        }

        public override StringValue ApplyTo(NumericValue numericValue)
        {
            var str = new StringValue(ValueCaster.RenderAsString(numericValue)+" ");
            return str.Join(numericValue.DecimalValue == 1 ? _single : _plural);
        }
    }
}