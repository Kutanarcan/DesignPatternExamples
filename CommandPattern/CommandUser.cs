using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class CommandUser : ICommandUser
    {
        public int Result { get; set; }
        
        public string UserName => userName;

        private string userName;

        CommandProcessor commandProcessor;

        public CommandUser(string userName)
        {
            commandProcessor = new CommandProcessor();
            this.userName = userName;
        }

        public void AddNumber(Command command)
        {
            commandProcessor.ExecuteCommand(command);
        }

        public void UndoCommand()
        {
            commandProcessor.UndoCommand();
        }
    }
}
