/*
 * Peter McEwen
 * Feb 8, 2018
 * Output
 * display the name of the user
 */
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

namespace u1_02_PeterOutput
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

        private void btnShowGreeting_Click(object sender, RoutedEventArgs e)

        {
            lblOutput.Content = "Hello, " + entryName.Text;
           // TextInput += TextompositionEventHandler ;
        }


    }
}
