using System;
using System.Linq;
using System.ServiceModel;
using automation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ui.SpecFlowSOAP;

namespace automation.Steps.API
{
    [Binding]
    public class UserStepsAPI
    {

        private readonly ScenarioContext _scenarioContext;

        public UserStepsAPI(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"that I am connected to the API")]
        public void GivenThatIAmConnectedToTheApi()
        {
            var userService = GlobalHook.UserService;
            Assert.IsNotNull(GlobalHook.UserService);

            try
            {
                var serviceIsRunning = userService.Ping();
                _scenarioContext.Add("serviceIsRunning", serviceIsRunning);
            }
            catch (Exception)
            {
                Assert.Fail("API not running");
            }
        }

        [When(@"I requests all Users")]
        public void WhenIRequestsAllUsers()
        {
            var userService = GlobalHook.UserService;
            var serviceIsRunning = (bool)_scenarioContext["serviceIsRunning"];
            Assert.IsTrue(serviceIsRunning);

            var users = userService.GetUsers();
            _scenarioContext.Add("GetUsersResult", users);
        }

        [Then(@"the result should contain more than (.*) users")]
        public void ThenTheResultShouldContainMoreThanUsers(int minCount)
        {
            var users = (User[])_scenarioContext["GetUsersResult"];
            Assert.IsTrue(users.Length > minCount);
        }

        [Given(@"new user details ""(.*)"", (.*)")]
        public void GivenNewUserDetails(string name, int age) {
           //Arrange
            var user = new User() {Name = name, Age = age};
            _scenarioContext.Add("NewUser", user);
        }

        [When(@"I call add new user")]
        public void WhenICallAddNewUser()
        {
            //Arrange
            var userService = GlobalHook.UserService;
            var user = (User)_scenarioContext["NewUser"];

            //Act
            try
            {
                userService.AddUser(user);
            }
            catch (FaultException<GenericFault> e)
            {
                _scenarioContext.Add("ResponseCode", e.Detail.ResponseCode);
                _scenarioContext.Add("Message", e.Message);
            }

        }

        [Then(@"the users list should contain the new user")]
        public void ThenTheUsersListShouldContainTheNewUser()
        {
            //Arrange
            var userService = GlobalHook.UserService;
            var user = (User)_scenarioContext["NewUser"];

            //act
            var users = userService.GetUsers();
            var apiUser = users.FirstOrDefault(u => u.Name == user.Name);

            //Assert
            Assert.IsNotNull(apiUser);
        }

        [Then(@"the API should fail with a (.*) response code")]
        public void ThenTheApiShouldFailWithAResponseCode(int expectedCode)
        {
            var responseCode = int.Parse(_scenarioContext["ResponseCode"].ToString());
            var message = _scenarioContext["Message"].ToString();
            Assert.IsFalse(responseCode == 0);
            Assert.IsFalse(string.IsNullOrEmpty(message));

            Assert.AreEqual(expectedCode, responseCode);
        }


        [Given(@"that I am authenticated as User ""(.*)""")]
        public void GivenThatIAmAuthenticatedAsUser(string userName)
        {
            //Arrange
            var userService = GlobalHook.UserService;

            //Act
            var user = userService.GetUserByName(userName);

            //Assert
            Assert.IsNotNull(user);
            _scenarioContext.Add("UserName", userName);
            _scenarioContext.Add("AuthenticatedUser", user);
        }

        [When(@"age is updated with the number (.*)")]
        public void WhenAgeIsUpdatedWithTheNumber(int age)
        {
            //Arrange
            var userService = GlobalHook.UserService;
            var user = (User)_scenarioContext["AuthenticatedUser"];

            //Act
            _scenarioContext.Add("ExpectedAge", age);
            userService.SetAge(user.Id, age);
        }

        [Then(@"the users age will be updated")]
        public void ThenTheUsersAgeWillBeUpdated()
        {
            //Arrange
            var userService = GlobalHook.UserService;
            var userName = _scenarioContext["UserName"].ToString();
            var expectedAge = int.Parse(_scenarioContext["ExpectedAge"].ToString());
            //Act
            var user = userService.GetUserByName(userName);
            Assert.AreEqual(expectedAge, user.Age);

        }
    }
}
