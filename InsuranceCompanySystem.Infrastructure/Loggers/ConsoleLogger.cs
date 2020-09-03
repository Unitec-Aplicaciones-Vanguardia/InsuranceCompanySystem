using System;
using InsuranceCompanySystem.Core.Interfaces;

namespace InsuranceCompanySystem.Infrastructure.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine($"[{DateTime.Now}] - {message}");
        }
    }
}
