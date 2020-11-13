using System;
using System.Collections.Generic;
using System.Text;
using BridgePattern.Resources;

namespace BridgePattern.Views
{
    public class LongFormView : View
    {
        public LongFormView(IResource resource)
            : base(resource)
        {
        }

        public override string Show()
        {
            StringBuilder builder = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.Cyan;

            builder.AppendLine("LONG VIEW FORM")
                .AppendLine(resource.Title())
                .AppendLine(resource.Image())
                .AppendLine(resource.Snippet())
                .AppendLine(resource.URL())
                .AppendLine();

            return builder.ToString();
        }
    }
}
