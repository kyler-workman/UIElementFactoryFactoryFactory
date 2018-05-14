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
    /// Interaction logic for CSElements.xaml
    /// </summary>
    public partial class CSElements : UserControl
    {
        public CSElement ElementSelected { get; set; }
        public CSElements()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            ElementSelected = (CSElement)Enum.Parse(typeof(CSElement), b.Name);
            ItemSelected.Content = ElementSelected.ToString();
        }
    }

    public enum CSElement
    {
        Button,
        TextBox
    }
}
