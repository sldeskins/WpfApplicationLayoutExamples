using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationLayoutExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WindowGrid());

            //NavigationWindow window = new NavigationWindow();
            //window.Source = new Uri("WindowGrid.xaml", UriKind.Relative);
            //window.Show(); 
            
        }

        private void buttonStack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WindowStack());

            //NavigationWindow window = new NavigationWindow();
            //window.Source = new Uri("WindowGrid.xaml", UriKind.Relative);
            //window.Show(); 
        }
    }
}
