using System.IdentityModel.Policy;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace CustomisationService.Core
{
    /// <summary>
    /// Read more about this here 
    /// https://msdn.microsoft.com/en-us/library/ff647503.aspx
    /// 
    /// </summary>
    public class SuperServiceAuthorizationManager : ServiceAuthorizationManager
    {
        public SuperServiceAuthorizationManager()
        {

        }

        public override bool CheckAccess(OperationContext operationContext)
        {
            return base.CheckAccess(operationContext);
        }

        public override bool CheckAccess(OperationContext operationContext, ref Message message)
        {

            var ac = operationContext.ServiceSecurityContext.AuthorizationPolicies;
            foreach (var i in ac)
            {
                if (i is AccessPermittedAuthorisationPolicy)
                {
                    var ii = i as AccessPermittedAuthorisationPolicy;
                    if (ii != null)
                    {
                        if (ii.Identifer == "hello")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

            //return base.CheckAccess(operationContext, ref message);
        }

        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            return base.CheckAccessCore(operationContext);
        }

        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> GetAuthorizationPolicies(OperationContext operationContext)
        {
            return base.GetAuthorizationPolicies(operationContext);
        }
    }
}
