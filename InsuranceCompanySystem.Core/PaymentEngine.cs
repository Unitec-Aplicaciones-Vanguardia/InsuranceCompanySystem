using InsuranceCompanySystem.Core.Interfaces;
using InsuranceCompanySystem.Core.Raters;

namespace InsuranceCompanySystem.Core
{
    public class PaymentEngine
    {
        private readonly ILogger _logger;
        private readonly IPolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;
        private readonly RaterFactory _raterFactory;
        public decimal Rating { get; set; }

        public PaymentEngine(
            ILogger logger,
            IPolicySource policySource,
            IPolicySerializer policySerializer,
            RaterFactory raterFactory)
        {
            _logger = logger;
            _policySource = policySource;
            _policySerializer = policySerializer;
            _raterFactory = raterFactory;
        }

        public void Rate()
        {
            _logger.Log("Starting rate");
            _logger.Log("Loading policy");

            var policyJson = _policySource.GetPolicyFromSource();
            var policy = _policySerializer.SerializePolicy(policyJson);
            var rater = _raterFactory.Create(policy);
            Rating = rater.Rate(policy);
            _logger.Log("Rating completed.");
        }
    }
}
