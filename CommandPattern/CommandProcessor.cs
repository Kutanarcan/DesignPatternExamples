using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class CommandProcessor
    {
        Stack<Command> commands = new Stack<Command>();

        public void ExecuteCommand(Command command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void UndoCommand()
        {
            if (commands.Count <= 0)
                return;

            var command = commands.Pop();
            command.Undo();
        }

        public void RedoCommand()
        {
            var command = commands.Peek();
            commands.Push(command);
            command.Execute();
        }
    }
}
