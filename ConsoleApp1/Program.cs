using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());

            userService.Create(new User
            {
                Username = "Test"
            }).Wait();

            Console.WriteLine(userService.Update(1,new User
            {
                Username = "Test User"
            }).Result);

            Console.WriteLine(userService.Delete(1).Result);
            Console.ReadLine();
        }
    }
}
