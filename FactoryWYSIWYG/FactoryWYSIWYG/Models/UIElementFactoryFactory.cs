using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.Models
{//store
    abstract public class UIElementFactoryFactory
    {
        private UIElementFactory UIElementFactory;
        abstract public UIElementFactory CreateUIElementFactory();

        public UIElementFactoryFactory()
        {
            this.UIElementFactory = this.CreateUIElementFactory();
        }
        public UIElement GenerateUiElement(string tag, string content, int height, int width, int topDistance, int leftDistance) => UIElementFactory.CreateUIElement(tag, content, height, width, topDistance, leftDistance);
        }
            
    
}
