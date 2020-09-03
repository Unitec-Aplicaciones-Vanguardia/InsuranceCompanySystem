using InsuranceCompanySystem.Core.Models;

namespace InsuranceCompanySystem.Core.Interfaces
{
    public interface IPolicySerializer
    {
        Policy SerializePolicy(string policyJson);
    }
}
