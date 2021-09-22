namespace SpecFlowSOAP
{
    public class MockUserData
    {
        public static User[] GetUsers()
        {
            return new[]
            {
                new User(1,"Craig",28),
                new User(2,"John",22),
                new User(3,"Sally",22),
                new User(4,"Rebecca",33),
                new User(5,"Phillip", 40),
            };
        }
    }
}
