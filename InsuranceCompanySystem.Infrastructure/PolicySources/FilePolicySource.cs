using System.IO;
using InsuranceCompanySystem.Core.Interfaces;

namespace InsuranceCompanySystem.Infrastructure.PolicySources
{
    public class FilePolicySource : IPolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
