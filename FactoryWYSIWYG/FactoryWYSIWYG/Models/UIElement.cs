using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.Models
{
    abstract public class UIElement
    {


        public string Tag { get; set; }
        public string Content { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int TopDistance { get; set; }
        public int LeftDistance { get; set; }   
    }
}
