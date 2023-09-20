namespace Application.Domain.Services
{
    using System.Collections.Generic;
    using HexDemo.Domain.Ports;

    public class UserDetailService : IUserDetailService
    {
        private readonly IUserDetails userDetails;
        public UserDetailService(IUserDetails userDetails)
        {

            this.userDetails = userDetails;
        }
        public List<string> GetUsers()
        {
            return userDetails.GetUsers();
        }
    }
}
