namespace Specification.Models
{
    public class Customer : Entity
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public bool IsAvailable { get; private set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Disable() => IsAvailable = false;
    }
}
