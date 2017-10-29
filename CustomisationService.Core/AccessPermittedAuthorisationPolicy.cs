using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomisationService.Core
{
    class AccessPermittedAuthorisationPolicy : IAuthorizationPolicy
    {
        public ClaimSet Issuer => ClaimSet.System;

        public string Id => "permitted";

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            return true;
        }
        public string Identifer { get; internal set; }
    }
}
