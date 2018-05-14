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

namespace FactoryWYSIWYG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            content.Title.Content = "Content:";
            height.Title.Content = "Height:";
            width.Title.Content = "Width:";
            top.Title.Content = "Top:";
            left.Title.Content = "Left:";
        }
        

        private void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selector.IsEnabled = false;
            if (Selector.SelectedIndex == 0)
            {
                ButtonContainer.Children.Add(new HTMLElements());
            }
            else
            {
                ButtonContainer.Children.Add(new CSElements());
            }
            vars.Visibility = Visibility.Visible;
        }
    }
}
