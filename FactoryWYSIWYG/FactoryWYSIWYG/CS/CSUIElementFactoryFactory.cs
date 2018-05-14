using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.CS
{
    public class CSUIElementFactoryFactory : UIElementFactoryFactory
    {
        public override UIElementFactory CreateUIElementFactory()
        {
            return new CSUIElementFactory();
        }
    }
}
