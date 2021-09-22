using System;
using System.IO;
using System.Net;
using System.Xml;

namespace UserClient.Core
{
    public class SOAPEngine
    {
        /// <summary>
        /// Execute a Soap WebService call
        /// </summary>
        public string Execute(XmlDocument soapEnvelopeXml)
        {
            HttpWebRequest request = CreateWebRequest();
            string result;

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    result = rd.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
            return result;
        }

        /// <summary>
        /// Create a soap webrequest to [Url]
        /// </summary>
        /// <returns></returns>
        public HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(QuickSetup.ApiEndPoint);
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}
