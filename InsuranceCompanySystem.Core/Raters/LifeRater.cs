using System;
using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Raters
{
    //InsuranceCompanySystem.Core.Raters.LifeRater
    public class LifeRater : Rater
    {
        public LifeRater(ILogger logger)
            : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            Logger.Log("Rating life policy...");
            Logger.Log("Validating policy.");
            if (string.IsNullOrEmpty(policy.FullName))
            {
                Logger.Log("Life policy must include full name.");
                return 0m;
            }
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Logger.Log("Life policy must include Date of Birth.");
                return 0m;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Logger.Log("Centenarians are not eligible for coverage.");
                return 0m;
            }
            if (policy.Amount == 0)
            {
                Logger.Log("Life policy must include an Amount.");
                return 0m;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                return baseRate * 2;
            }
            return baseRate;
        }
    }
}
