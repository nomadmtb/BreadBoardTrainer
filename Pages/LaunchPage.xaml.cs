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

namespace BreadBoardTrainer
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class LaunchPage : Page
    {
        public LaunchPage()
        {
            InitializeComponent();
        }

        private void pushButton_Click(object sender, RoutedEventArgs e)
        {
            this.pushButton.Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
