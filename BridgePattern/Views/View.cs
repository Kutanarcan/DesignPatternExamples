using System;
using System.Collections.Generic;
using System.Text;
using BridgePattern.Resources;

namespace BridgePattern.Views
{
    public abstract class View
    {
        protected IResource resource;

        public View(IResource resource)
        {
            this.resource = resource;
        }

        public abstract string Show();
    }
}
