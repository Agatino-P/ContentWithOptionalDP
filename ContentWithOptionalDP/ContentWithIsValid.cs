using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ContentWithOptionalDP
{
    public class ContentWithIsValid : DependencyObject
    {
        public ContentWithIsValid(bool isValid)
        {
            IsValid = isValid;
        }

        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            set { SetValue(IsValidProperty, value); }
        }
        public static readonly DependencyProperty IsValidProperty =
            DependencyProperty.Register("IsValid", typeof(bool), typeof(ContentWithIsValid), new PropertyMetadata(false, onIsValidChange,isValidCoerce));

        private static object isValidCoerce(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void onIsValidChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            return;
        }
    }
}
