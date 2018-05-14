using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.Models
{
    abstract public class UIElementFactory
    {
        abstract public UIElement CreateUIElement();
    }
}
