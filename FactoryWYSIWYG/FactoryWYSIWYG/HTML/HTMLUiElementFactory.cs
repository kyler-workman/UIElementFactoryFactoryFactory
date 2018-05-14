using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.HTML{
    public class HTMLUIElementFactory : UIElementFactory
    { 
        public override UIElement CreateUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance)
        {
            return new HTMLUIElement(tag,content,height,width,topDistance,leftDistance);
        }
    }
}
