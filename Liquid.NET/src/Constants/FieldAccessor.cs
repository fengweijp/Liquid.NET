﻿using Liquid.NET.Utils;

namespace Liquid.NET.Constants
{
    public static class FieldAccessor
    {
        public static LiquidExpressionResult TryField(
            ITemplateContext ctx, 
            ILiquidValue liquidValue, 
            string index)
        {

            var dict = liquidValue as LiquidHash;
            if (dict == null)
            {
                return LiquidExpressionResult.ErrorOrNone(ctx, index);
                          
            }

            return dict.ContainsKey(index)
                ? LiquidExpressionResult.Success(dict[index])
                : LiquidExpressionResult.ErrorOrNone(ctx, index);
        }
    }
}
