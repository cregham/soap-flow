using System.Runtime.Serialization;
using System.ServiceModel;

namespace soapapi
{
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User[] GetUsers();

        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void RemoveUser(int id);
        [OperationContract]
        void SetName(int id, string name);
        [OperationContract]
        void SetAge(int id, int age);
    }

// Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class User
    {
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}