using PS.Domain.Entities;
using System;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Provider P1 = new Provider
            {
                Password = "123",
                ConfirmPassword = "123",
                IsApproved = false

            };
            string ConfirmPassword = P1.ConfirmPassword;
            string Password = P1.Password;
            bool IsApproved = P1.IsApproved;

            //P1.SetIsApproved(ref ConfirmPassword, ref Password, ref IsApproved);
            System.Console.WriteLine(P1.IsApproved);
            System.Console.WriteLine(P1.Password);
            System.Console.WriteLine(P1.ConfirmPassword);

            P1.SetIsApproved(P1);
            System.Console.WriteLine(P1.IsApproved);


        }
    }
}
