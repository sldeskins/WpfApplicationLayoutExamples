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
    /// Interaction logic for WindowGrid.xaml
    /// </summary>
    public partial class WindowGrid : Page
    {
        public WindowGrid()
        {
            InitializeComponent();
        }
        string GRID_BOTTON_NAME_PREFIX = "button";
        private void button_Click(object sender, RoutedEventArgs e)

        {
            resetButtonColor();

            int lengthBttmPrefix = GRID_BOTTON_NAME_PREFIX.Length;
            Button btnSelected = (Button)sender;
            string name = btnSelected.Name;
            int row = int.Parse(name.Substring(lengthBttmPrefix, 1));
            int col = int.Parse(name.Substring(lengthBttmPrefix + 1, 1));
            var thebutton = (Button)this.FindName(GRID_BOTTON_NAME_PREFIX + row + col);
            thebutton.Background = Brushes.Cyan;
        }
        public void resetButtonColor()
        {

            for (int rowi = 0; rowi < 3; rowi++)
            {
                for (int colj = 0; colj < 3; colj++)
                {
                    var thebutton = (Button)this.FindName(GRID_BOTTON_NAME_PREFIX + rowi + colj);
                    thebutton.Background = Brushes.NavajoWhite;
                }
            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack(); 
        }
    }
}
