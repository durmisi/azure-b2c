using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClient
{
    public static class Globals
    {
        public static string taskServiceUrl = "https://localhost:44332/";
        public static string aadInstance = "https://login.microsoftonline.com/";
      
        // TODO: Replace these five default with your own configuration values
        public static string tenant = "myb2c.onmicrosoft.com";

        public static string clientId = "2dd79d85-28c6-4d48-a8fd-7fdecef546ac";
        public static string redirectUri = "urn:ietf:wg:oauth:2.0:oob";

        public static string signInPolicy = "B2C_1_sign_in";
        public static string signUpPolicy = "B2C_1_sign-up";
        public static string editProfilePolicy = "B2C_1_edit_profile";

        public static string authority = string.Concat(aadInstance, tenant);

    }
}
