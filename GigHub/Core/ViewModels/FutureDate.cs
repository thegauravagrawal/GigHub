﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Core.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}