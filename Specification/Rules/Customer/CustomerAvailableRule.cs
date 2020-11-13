using Specification.Rules.Abstractions;

namespace Specification.Rules.Customer
{
    public class CustomerAvailableRule : CompositeRule<Models.Customer>
    {
        public override bool IsSatisfiedBy(Models.Customer model)
        {
            return model?.IsAvailable == true;
        }
    }
}
