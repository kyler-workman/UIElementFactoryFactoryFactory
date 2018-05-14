using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.CS
{
    class CSUIElementFactory : UIElementFactory
    {
        public override UIElement CreateUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance)
        {
            return new CSUIElement(tag, content, height, width, topDistance, leftDistance);
        }
    }
}
