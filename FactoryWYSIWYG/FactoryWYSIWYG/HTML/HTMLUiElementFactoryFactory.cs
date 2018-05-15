using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.HTML
{
    public class HTMLUIElementFactoryFactory : UIElementFactoryFactory
    {
        public override UIElementFactory CreateUIElementFactory()
        {
            return new HTMLUIElementFactory();
        }
    }
}
