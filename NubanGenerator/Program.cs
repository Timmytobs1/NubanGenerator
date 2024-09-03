using System;

namespace NubanGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nubanService = new NubanService();

            string institutionCode = "000011";
            string accountSerialNumber = "000001456";
            string nuban = nubanService.GenerateNuban(institutionCode, accountSerialNumber);

            Console.WriteLine($"Generated NUBAN: {nuban}");
        }
    }
}
