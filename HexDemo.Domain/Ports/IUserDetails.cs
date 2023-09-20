namespace HexDemo.Domain.Ports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserDetails
    {
        List<string> GetUsers();
    }
}
