using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.Models
{//AKA Store
    abstract public class UIElementFactoryFactory
    {
        private UIElementFactory _UIElement;
        public abstract UIElementFactory CreateFactory();




    }
}
