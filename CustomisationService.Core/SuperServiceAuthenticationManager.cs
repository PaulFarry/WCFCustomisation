using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;

namespace CustomisationService.Core
{
    public class SuperServiceAuthenticationManager : ServiceAuthenticationManager
    {
        public override ReadOnlyCollection<IAuthorizationPolicy> Authenticate(ReadOnlyCollection<IAuthorizationPolicy> authPolicy, Uri listenUri, ref Message message)
        {
            var myHeaderIndex = message.Headers.FindHeader("x-accesstoken", "");

            var hh = message.Headers.GetHeader<string>(myHeaderIndex);


            var pol = new AccessPermittedAuthorisationPolicy
            {
                Identifer = hh
            };

            var l = new List<IAuthorizationPolicy>
            {
                pol
            };


            return new ReadOnlyCollection<IAuthorizationPolicy>(l);
        }

    }
}
