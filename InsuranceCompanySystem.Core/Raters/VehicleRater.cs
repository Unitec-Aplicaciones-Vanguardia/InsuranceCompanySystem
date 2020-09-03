using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Raters
{
    public class VehicleRater : Rater
    {
        public VehicleRater(ILogger logger)
            : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Rating vehicle policy");
            Logger.Log("Validating policy");

            if (string.IsNullOrEmpty(policy.Make))
            {
                Logger.Log("Vehicle policy must specify Make");
                return 0m;
            }
            if (policy.NumberOfWheels != 4)
            {
                Logger.Log("Only vehicles with 4 wheels are accepted");
                return 0m;
            }
            if (policy.Make == "MAZDA")
            {
                if (policy.Deductible < 500)
                {
                    return 2000m;
                }
                return 1000m;
            }

            return 0m;
        }
    }
}
