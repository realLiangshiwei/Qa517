using Volo.Abp.Domain.Entities;

namespace Qa517.Users
{
    public class AppUserSqlView : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public override object[] GetKeys()
        {
            return new object[] {Name, Email};
        }
    }
}
