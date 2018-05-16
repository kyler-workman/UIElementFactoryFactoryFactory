using FactoryWYSIWYG.CS;
using FactoryWYSIWYG.HTML;
using FactoryWYSIWYG.Models;
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
        public UIElementFactoryFactory ElementGenerator { get; set; }
        Stack<Models.UIElement> Elements = new Stack<Models.UIElement>();
        public MainWindow()
        {
            InitializeComponent();
            content.Title.Content = "Content:";
            height.Title.Content = "Height:";
            width.Title.Content = "Width:";
            top.Title.Content = "Top:";
            left.Title.Content = "Left:";
            AddedElements.ItemsSource = Elements;
        }
        

        private void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selector.IsEnabled = false;
            if (Selector.SelectedIndex == 0)
            {
                ButtonContainer.Children.Add(new HTMLElements() { Name = "ElementSelector" });
                ElementGenerator = new HTMLUIElementFactoryFactory();
            }
            else
            {
                ButtonContainer.Children.Add(new CSElements() { Name = "ElementSelector"});
                ElementGenerator = new CSUIElementFactoryFactory();
            }
            vars.Visibility = Visibility.Visible;
            Add.Visibility = Visibility.Visible;
            Comp.Visibility = Visibility.Visible;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            bool badinput = false;
            if (!int.TryParse(left.Input.Text, out int x))
            {
                left.Input.Text = "Enter Number";
                badinput = true;
            }
            if (!int.TryParse(top.Input.Text, out int y))
            {
                top.Input.Text = "Enter Number";
                badinput = true;
            }
            if (!int.TryParse(width.Input.Text, out int w))
            {
                width.Input.Text = "Enter Number";
                badinput = true;
            }
            if (!int.TryParse(height.Input.Text, out int h))
            {
                height.Input.Text = "Enter Number";
                badinput = true;
            }
            try
            {
                ((ElementsList)ButtonContainer.Children[0]).ElementSelected.ToString();
            }
            catch (Exception)
            {
                badinput = true;
            }

            if (badinput) return;

            Models.UIElement NewElement = ElementGenerator.GenerateUiElement(((ElementsList)ButtonContainer.Children[0]).ElementSelected.ToString(), content.Input.Text, h, w, y, x);
            Elements.Push(NewElement);
            AddedElements.Items.Refresh();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Elements.Pop();
            AddedElements.Items.Refresh();
        }

        private void CompileButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
