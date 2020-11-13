using System;
using CommandPattern.Commands;
namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandUser commandUser = new CommandUser("John");
            CommandUser commandUser2 = new CommandUser("Jack");

            commandUser.AddNumber(new AddCommand(commandUser, 5));
            commandUser.AddNumber(new AddCommand(commandUser, 4));
            commandUser.AddNumber(new AddCommand(commandUser, 4));
            commandUser2.AddNumber(new AddCommand(commandUser2,3));
            commandUser2.AddNumber(new AddCommand(commandUser2,2));
            commandUser.UndoCommand();
            commandUser.UndoCommand();

            Console.ReadKey();
        }
    }
}
