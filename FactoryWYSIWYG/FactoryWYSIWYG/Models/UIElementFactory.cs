using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.Models
{//AKA Factory
    abstract public class UIElementFactory
    {
        abstract public UIElement CreateUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance);

        abstract public void Compile(Stack<UIElement> tags);
    }
}
