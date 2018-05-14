using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.HTML
{
    public class HTMLUIElement : UIElement
    {
        public HTMLUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance)
        {
            Tag = tag;
            Content = content;
            Height = height;
            Width = width;
            TopDistance = topDistance;
            LeftDistance = leftDistance;
        }
    }
}
