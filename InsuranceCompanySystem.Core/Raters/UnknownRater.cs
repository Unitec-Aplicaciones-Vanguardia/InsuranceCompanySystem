using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Raters
{
    public class UnknownRater : Rater
    {
        public UnknownRater(ILogger logger)
            : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Unknown policy type");
            return 0m;
        }
    }
}
