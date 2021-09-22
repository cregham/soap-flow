using System.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
namespace SpecFlowSOAP
{
    public class UserService : IUserService
    {

        public User GetUser(int id)
        {
            var users = MockUserData.GetUsers();
            var user = users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public User[] GetUsers()
        {
            return MockUserData.GetUsers();
        }
    }
}
