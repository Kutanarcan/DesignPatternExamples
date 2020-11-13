using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommandUser
    {
        string UserName { get; }
        int Result { get; set; }
    }
}
