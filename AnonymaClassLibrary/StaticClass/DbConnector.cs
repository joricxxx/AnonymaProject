using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
