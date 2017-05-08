using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinosDePortugal.Models
{
    public class Helpers
    {
       
            public static string SHA1_Encode(string value)
            {
                var hash = System.Security.Cryptography.SHA1.Create();
                var encoder = new System.Text.ASCIIEncoding();
                var combined = encoder.GetBytes(value ?? "");
                return BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");
            }
        

    }
}