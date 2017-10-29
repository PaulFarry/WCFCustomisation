using CustomisationService.Contract;
using CustomisationService.Core;
using System.ServiceModel;

namespace CustomisationService.Proxy
{
    public class Client : ClientBase<ICommunicate>, ICommunicate
    {
        public Client() : base("Simple") { }


        public string GetData(int value)
        {
            return Channel.GetData(value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return Channel.GetDataUsingDataContract(composite);
        }
    }
}
