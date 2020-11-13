using Specification.Rules.Abstractions;

namespace Specification.Rules.Customer
{
    public class CustomerNameRule : CompositeRule<Models.Customer>
    {
        public override bool IsSatisfiedBy(Models.Customer model)
        {
            return model?.Name.Length > 3;
        }
    }
}