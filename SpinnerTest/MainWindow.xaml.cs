using System.Windows;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.Spinner.Visibility == Visibility.Collapsed || this.Spinner.Visibility == Visibility.Hidden)
            {
                this.Spinner.Visibility = Visibility.Visible;
            }
            else
            {
                this.Spinner.Visibility = Visibility.Collapsed;
            }
        }
    }
}
