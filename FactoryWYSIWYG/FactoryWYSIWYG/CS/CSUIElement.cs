using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.CS
{
    class CSUIElement : UIElement
    {
        public CSUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance)
        {
            Tag = tag;
            Content = content;
            Height = height;
            Width = width;
            TopDistance = topDistance;
            LeftDistance = leftDistance;
        }

        public override string ToTag()
        {
            throw new NotImplementedException();
        }
    }
}
