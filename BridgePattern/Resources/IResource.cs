using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Resources
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string Image();
        string URL();
    }
}
