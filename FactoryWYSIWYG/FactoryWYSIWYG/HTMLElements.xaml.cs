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
    /// Interaction logic for HTMLElements.xaml
    /// </summary>
    public partial class HTMLElements : UserControl
    {
        
        public HtmlElementEnum ElementSelected { get; set; }

        public HTMLElements()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            ElementSelected = (HtmlElementEnum)Enum.Parse(typeof(HtmlElementEnum),b.Name);
            ItemSelected.Content = ElementSelected.ToString();
        }
    }

    public enum HtmlElementEnum
    {
        Button,
        TextBox,
        Div,
        P
    }
}
