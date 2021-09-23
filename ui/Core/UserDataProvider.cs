﻿using System.Collections.Generic;
using System.Xml;
using ui.SpecFlowSOAP;

namespace ui.Core
{
    public class UserDataProvider
    {
        private readonly UserServiceClient _userServiceClient;

        public UserDataProvider()
        {
            _userServiceClient = new UserServiceClient();
        }

        public User[] GetUsers()
        {
            return _userServiceClient.GetUsers();
        }

        public User GetUser(int id)
        {
            return _userServiceClient.GetUser(id);
        }

        public void AddUser(User user)
        { 
            _userServiceClient.AddUser(user);
        }

        public void RemoveUser(int id)
        {
            _userServiceClient.RemoveUser(id);
        }

        public void SetAge(int id, int age)
        {
            _userServiceClient.SetAge(id, age);
        }

        public void SetName(int id, string name)
        {
            _userServiceClient.SetName(id, name);
        }
    }
}
