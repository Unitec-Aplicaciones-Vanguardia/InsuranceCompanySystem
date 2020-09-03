using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Raters
{
    public abstract class Rater
    {
        public ILogger Logger { get; set; }

        protected Rater(ILogger logger)
        {
            Logger = logger;
        }

        public abstract decimal Rate(Policy policy);
    }
}
