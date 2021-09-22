

using System.Collections.Generic;
using System.Xml;
using UserClient.SpecFlowSOAP;

namespace UserClient.Core
{
    public class UserDataProvider
    {
        private readonly SOAPEngine _soapEngine;
        private readonly UserServiceClient _userServiceClient;

        public UserDataProvider()
        {
            _soapEngine = new SOAPEngine();
            _userServiceClient = new UserServiceClient();
        }

        public User[] GetUsersClient()
        {
            return _userServiceClient.GetUsers();
        }


        public IEnumerable<User> GetUsersManual()
        {

            XmlDocument soapEnvelopeXml = new XmlDocument();

            soapEnvelopeXml.LoadXml(@"<s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"">
                <s:Header>
                    <Action s:mustUnderstand=""1"" xmlns=""http://schemas.microsoft.com/ws/2005/05/addressing/none"">http://tempuri.org/IUserService/GetUsersManual</Action>
                </s:Header>
                <s:Body>
                    <GetUsersManual xmlns=""http://tempuri.org/"" />
                </s:Body>
            </s:Envelope>");

            var result = _soapEngine.Execute(soapEnvelopeXml);


            return new List<User>();
        }
    }
}
