using System;

namespace InsuranceCompanySystem.Core.Models
{
    public class Policy
    {
        public PolicyType Type { get; set; }

        #region Life
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsSmoker { get; set; }

        public decimal Amount { get; set; }

        #endregion

        #region Vehicle

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Miles { get; set; }

        public int NumberOfWheels { get; set; }

        public decimal Deductible { get; set; }

        #endregion

        #region House

        public string Address { get; set; }

        public decimal Size { get; set; }

        public decimal Valuation { get; set; }

        public decimal BondAmount { get; set; }

        #endregion

        #region Flood
        public int ElevationAboveSeaLevelFeet { get; set; }
        #endregion
    }
}
