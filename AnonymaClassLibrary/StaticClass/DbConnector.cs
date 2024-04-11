using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnonymaClassLibrary.Model;

namespace AnonymaClassLibrary.StaticClass
{
    public static class DbConnector
    {
        private static IFirebaseConfig config { get; set; } = new FirebaseConfig
        {
            AuthSecret = "dpJHVdb7UxaZKz18Ij92gEY3vKzwPybUBohcLaED",
            BasePath = "https://anonymadb-74fac-default-rtdb.firebaseio.com/"
        };
        private static IFirebaseClient client { get; set; } = new FirebaseClient(config);
        /// <summary>
        /// method to upload message into the firebase
        /// </summary>
        /// <param name="Key">The  key means the identifier of the message,
        /// this is randomly generated and composed of 30 characters</param>
        /// <param name="message"></param>
        public static async void uploadMessage(string Key, Message message)
        {
            string path = $"SecretMessages/{Key}";
            var response = await client.SetTaskAsync(path, message.serialize());
        }
    }
}
