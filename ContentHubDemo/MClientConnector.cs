using Stylelabs.M.Sdk.WebClient;
using Stylelabs.M.Sdk.WebClient.Authentication;
using System;

namespace ContentHubDemo
{
    public static class MClientConnector
    {
        public static IWebMClient Client
        {
            get
            {
                Uri endpoint = new Uri("https://jwt-q-001.sitecorecontenthub.cloud/");
                OAuthPasswordGrant oauth = new OAuthPasswordGrant
                {
                    ClientId = "test_developer",
                    ClientSecret = "51fc5637-4c9f-4ffa-99ce-865b27842805",
                    UserName = "himmat.dulawat@wundermanthompson.com",
                    Password = "Himm@t20987"
                };
                return MClientFactory.CreateMClient(endpoint, oauth);
            }
        }
    }
}
