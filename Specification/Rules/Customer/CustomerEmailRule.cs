using Specification.Rules.Abstractions;

namespace Specification.Rules.Customer
{
    public class CustomerEmailRule : CompositeRule<Models.Customer>
    {
        public override bool IsSatisfiedBy(Models.Customer model)
        {
            return model?.Email.Contains("@") == true;
        }
    }
}
