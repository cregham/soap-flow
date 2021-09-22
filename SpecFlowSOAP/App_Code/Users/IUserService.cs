using System.Runtime.Serialization;
using System.ServiceModel;

namespace SpecFlowSOAP
{
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User[] GetUsers();
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