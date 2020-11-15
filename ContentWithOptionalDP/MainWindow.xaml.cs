using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContentWithOptionalDP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public object CCContent
        {
            get { return (object)GetValue(CCContentProperty); }
            set { SetValue(CCContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CCContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CCContentProperty =
            DependencyProperty.Register("CCContent", typeof(object), typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
        }
        public void SetContent(object content)
        {
            CCContent= content;
        }

        private void btnWithIsValidTrue_Click(object sender, RoutedEventArgs e)
        {
            SetContent(new ContentWithIsValid(true));
        }

        private void btnWithIsValidFalse_Click(object sender, RoutedEventArgs e)
        {
            SetContent(new ContentWithIsValid(false));
        }
        private void btnWithoutIsValid_Click(object sender, RoutedEventArgs e)
        {
            SetContent(new ContentWithoutIsValid());
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
            this.Close();    
            //DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancel");
            this.Close();
            //DialogResult = false;
        }
    }
}
