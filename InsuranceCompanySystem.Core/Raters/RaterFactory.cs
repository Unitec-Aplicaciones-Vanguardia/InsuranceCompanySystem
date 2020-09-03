using System;
using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Raters
{
    public class RaterFactory
    {
        private readonly ILogger _logger;

        public RaterFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Rater Create(Policy policy)
        {
            try
            {
                return (Rater)Activator.CreateInstance(Type.GetType($"InsuranceCompanySystem.Core.Raters.{policy.Type}Rater"),
                    new object[]
                    {
                        _logger 
                    });
            }
            catch
            {
                return new UnknownRater(_logger);
            }
        }
    }
}
