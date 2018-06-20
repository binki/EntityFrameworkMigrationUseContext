using EntityFrameworkMigrationUseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkMigrationUseContext
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = null;
            var commands = new Dictionary<string, Action<ProgramContext>>
            {
                {
                    "add",
                    context=>
                    {
                        context.Users.Add(new User{
                            Name = prompt("name="),
                            Email = prompt("email="),
                        });
                    }
                },
                {
                    "list",
                    context =>
                    {
                        foreach (var user in context.Users)
                        {
                            Console.WriteLine($"{user.Email}: name={user.Name}");
                        }
                    }
                },
                {
                    "set-connection",
                    context =>
                    {
                        var newString = prompt("connection=");
                        connectionString = newString == "" ? null : newString;
                    }
                },
            };
            while (true)
            {
                Console.WriteLine($"Commands: {string.Join(" ", commands.Keys.OrderBy(k => k))}");
                var commandName = prompt(">");
                if (commandName == null) break;
                if (commands.TryGetValue(commandName, out var command))
                {
                    using (var context = connectionString == null ? new ProgramContext() : new ProgramContext(connectionString))
                    {
                        command(context);
                        context.SaveChanges();
                    }
                }
            }

            string prompt(string promptText)
            {
                Console.Write(promptText);
                return Console.ReadLine();
            }
        }
    }
}
