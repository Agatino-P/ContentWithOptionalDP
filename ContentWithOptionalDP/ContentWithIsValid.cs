using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ContentWithOptionalDP
{
    public class ContentWithIsValid : DependencyObject
    {
        private bool _isValid;

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
            DependencyProperty.Register("IsValid", typeof(bool), typeof(ContentWithIsValid));
    }
}
