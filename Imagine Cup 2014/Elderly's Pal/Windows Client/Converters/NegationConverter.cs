﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace NiceDreamers.Windows.Converters
{
    public class NegationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return -System.Convert.ToDouble(value, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}