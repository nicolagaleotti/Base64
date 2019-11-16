using System;
using System.Text;

namespace EsercizioBase64
{
    public class LibraryBase64
    {
        public static string Base64 ()
        {
        string toEncode = "Nicola";
        byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

        string returnValue = Convert.ToBase64String(toEncodeAsBytes);

      return returnValue;
            }
    }
}
