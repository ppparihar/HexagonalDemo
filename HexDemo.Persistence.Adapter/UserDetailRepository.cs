namespace HexDemo.Persistence.Adapter
{
    using System.ComponentModel;
    using HexDemo.Domain.Ports;

    public class UserDetailRepository : IUserDetails
    {
        public List<string> GetUsers()
        {
            // Add Mapping logic here
            return new List<string> { "user1", "user2" };
        }
    }
}