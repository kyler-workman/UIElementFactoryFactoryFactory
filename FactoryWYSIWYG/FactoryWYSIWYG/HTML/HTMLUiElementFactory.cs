using FactoryWYSIWYG.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWYSIWYG.HTML
{
    public class HTMLUIElementFactory : UIElementFactory
    {
        public override void Compile(Stack<UIElement> tags)
        {
            var f=File.Create(AppDomain.CurrentDomain.BaseDirectory + "\\generatedcode.html");
            f.Close();
            List<UIElement> toWrite = tags.Reverse().ToList();
            StringBuilder output = new StringBuilder("<!DOCTYPE html>\n<html>\n\t<head>\n\t\t<title>Generated File</title>\n\t</head>\n\t<body>\n");
            foreach(UIElement ue in toWrite)
            {
                output.AppendLine(ue.ToTag());
            }
            output.AppendLine("\t</body>\n</html>");
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\generatedcode.html", output.ToString());
        }

        public override UIElement CreateUIElement(string tag, string content, int height, int width, int topDistance, int leftDistance)
        {
            return new HTMLUIElement(tag, content, height, width, topDistance, leftDistance);
        }
    }
}
