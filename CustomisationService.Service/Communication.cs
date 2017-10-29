using CustomisationService.Contract;
using CustomisationService.Core;

namespace CustomisationService.Service
{
    public class Communication : ICommunicate
    {
        public string GetData(int value)
        {
            return (value * 2).ToString();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return new CompositeType { StringValue = $"{composite.StringValue} -- {composite.BoolValue}", BoolValue = !composite.BoolValue };
        }
    }
}