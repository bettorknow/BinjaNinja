using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.Extensions
{
    public static class ExceptionExtensions
    {
        public static T WhenNullThrow<T>(this T validation, string paramName)
        {
            if (validation == null)
            {
                throw new ArgumentNullException(paramName);
            }
            return validation;
        }
    }
}
