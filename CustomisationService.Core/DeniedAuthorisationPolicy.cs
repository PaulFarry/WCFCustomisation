using System;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;

namespace CustomisationService.Core
{
    public class DeniedAuthorisationPolicy : IAuthorizationPolicy
    {
        public ClaimSet Issuer => ClaimSet.System;

        public string Id => "deniedauthorisation";

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            return true;
        }
    }
}
