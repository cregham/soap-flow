using System.Linq;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
namespace soapapi
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class UserService : IUserService
    {
        private readonly MockUserData _mockData;

        public UserService()
        {
            _mockData = new MockUserData();
        }

        public User GetUser(int id)
        {
            var user = _mockData.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public User[] GetUsers()
        {
            return _mockData.Users;
        }

        public void AddUser(User user)
        {
            _mockData.AddUser(user);
        }

        public void RemoveUser(int id)
        {
            _mockData.RemoveUser(id);
        }

        public void SetName(int id, string name)
        {
            _mockData.SetName(id, name);
        }

        public void SetAge(int id, int age)
        { 
            _mockData.SetAge(id, age);
        }
    }
}
