using System.Runtime.Serialization;
using System.ServiceModel;

namespace soapapi
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        User GetUserById(int id);

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        User GetUserByName(string name);


        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        User[] GetUsers();

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        void AddUser(User user);

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        void RemoveUser(int id);

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        void SetName(int id, string name);

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        void SetAge(int id, int age);

        [OperationContract]
        [FaultContract(typeof(GenericFault))]
        bool Ping();
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