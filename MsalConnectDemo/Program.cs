using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace MsalConnectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {
            // Fill in the correct client ID for your app 
            // Go to https://apps.dev.microsoft.com/ to register an app
            const string clientId = "<GUID>";
            // Enter the required scopes
            string[] scopes = { "User.Read" };

            // Create the application context.
            var clientApplication = new PublicClientApplication(clientId);

            // Acquire an access token for the given scope.
            var authenticationResult = await clientApplication.AcquireTokenAsync(scopes);

            // Write the access token.
            Console.WriteLine(authenticationResult.Token);
        }
    }
}
