using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    class AddCommand : Command
    {
        int number;

        public AddCommand(ICommandUser commandUser, int number)
            : base(commandUser)
        {
            this.number = number;
        }

        public override void Execute()
        {
            commandUser.Result += number;
            Console.WriteLine($"{commandUser.UserName} - Add Command Executed: {commandUser.Result}");
        }

        public override void Undo()
        {
            commandUser.Result -= number;
            Console.WriteLine($"{commandUser.UserName} - Add Command Undo: {commandUser.Result}");
        }
    }
}
