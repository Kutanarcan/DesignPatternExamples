using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public abstract class Command
    {
        protected ICommandUser commandUser;

        public Command(ICommandUser commandUser)
        {
            this.commandUser = commandUser;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
