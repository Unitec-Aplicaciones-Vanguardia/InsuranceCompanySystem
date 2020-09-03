using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InsuranceCompanySystem.Infrastructure.PolicySerializers
{
    public class JsonPolicySerializer : IPolicySerializer
    {
        public Policy SerializePolicy(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json, new StringEnumConverter());
        }
    }
}
