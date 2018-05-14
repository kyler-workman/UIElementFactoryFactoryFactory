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
    /// Interaction logic for Entry.xaml
    /// </summary>
    public partial class Entry : UserControl
    {
        public TextBox Input { get; set; }
        public Label Title { get; set; }
        public Entry()
        {
            InitializeComponent();
            Input = TextBox;
            Title = title;
        }
    }
}
