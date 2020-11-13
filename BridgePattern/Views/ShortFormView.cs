using System;
using System.Collections.Generic;
using System.Text;
using BridgePattern.Resources;

namespace BridgePattern.Views
{
    class ShortFormView : View
    {
        public ShortFormView(IResource resource) 
            : base(resource)
        {
        }

        public override string Show()
        {
            StringBuilder builder = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            builder.AppendLine("SHORT VIEW FORM")
                .AppendLine(resource.Title())
                .AppendLine(resource.URL())
                .AppendLine(resource.Image())
                .AppendLine();

            return builder.ToString();
        }
    }
}
