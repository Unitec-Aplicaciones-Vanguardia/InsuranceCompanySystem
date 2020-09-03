using System;
using InsuranceCompanySystem.Core;
using InsuranceCompanySystem.Core.Raters;
using InsuranceCompanySystem.Infrastructure.Loggers;
using InsuranceCompanySystem.Infrastructure.PolicySerializers;
using InsuranceCompanySystem.Infrastructure.PolicySources;

namespace InsuranceCompanySystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insurance System Starting...");

            var logger = new FileLogger();

            var engine = new PaymentEngine(
                logger,
                new FilePolicySource(),
                new JsonPolicySerializer(), 
                new RaterFactory(logger));

            engine.Rate();

            if (engine.Rating > 0)
            {
                System.Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                System.Console.WriteLine("No rating produced.");
            }
        }
    }
}
