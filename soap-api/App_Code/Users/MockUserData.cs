using System;
using System.Linq;
using System.ServiceModel;

namespace soapapi
{
    /// <summary>
    /// Fake repository for interacting with User Data
    /// </summary>
    public class MockUserData
    {
        private User[] _users;

        public MockUserData()
        {
            Users = new[]
            {
             new User(1,"Craig",28),
             new User(2,"John",22),
             new User(3,"Sally",22),
             new User(4,"Rebecca",33),
             new User(5,"Phillip", 40),
         };
        }

        public User[] Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public void SetName(int id, string name)
        {
            var user = Users.FirstOrDefault(f => f.Id == id);
            if (user == null) SendGenericFault(418, string.Format(@"User with ID [{0}] not found.", id));
            user.Name = name;
        }

        public void SetAge(int id, int age)
        {
            var user = Users.FirstOrDefault(f => f.Id == id);
            if (user == null) SendGenericFault(418, string.Format(@"User with ID [{0}] not found.", id));
            user.Age = age;
        }

        public void AddUser(User user)
        {
            if (Users.Any(a => a.Name == user.Name)) SendGenericFault(418, "User with name already exists");
            var maxId =  Users.Max(u => u.Id);
            user.Id = maxId + 1;
            Array.Resize(ref _users, Users.Length + 1);
            Users[Users.Length - 1] = user;
        }

        public void RemoveUser(int id)
        {
            var user = Users.FirstOrDefault(f => f.Id == id);
            if (user == null) SendGenericFault(418, string.Format(@"User with ID [{0}] not found.", id));
            var index = Array.IndexOf(Users, user);
            Users = Users.RemoveAt(index);
        }

        private void SendGenericFault(int responseCode, string message)
        {
            GenericFault fault = new GenericFault(){ResponseCode = responseCode, Message = message};
            FaultReason faultReason = new FaultReason("Invalid user");

            throw new FaultException<GenericFault>(fault);
        }
    }
}
