using SimpleTrader.Domain.Models;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            var userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());

            userService.Create(new User
            {
                Username = "Test"
            }).Wait();

            Console.WriteLine(userService.Update(1, new User
            {
                Username = "Test User"
            }).Result);

            Console.WriteLine(userService.Delete(1).Result);
            Console.ReadLine();
        }
    }
}