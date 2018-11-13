using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module7_Task3
{
    public class URLString
    {
        /// <summary>
        /// Changes diameters in the URL line
        /// </summary>
        /// <param name="URL">URL string</param>
        /// <param name="parametr">Paramert</param>
        /// <returns></returns>
        public static string AddOrChangeUrlParameter(string URL, string parametr)
        {
            StringBuilder tmp = new StringBuilder();
            
            string[] arrayURLAndKeys = URL.Split('?');            

            tmp.Append(arrayURLAndKeys[0]+"?");


            switch (arrayURLAndKeys.Length)
            {
                case 0:
                    return "Error";

                case 1:
                    tmp.Append(parametr.Replace(" ", ""));
                    return tmp.ToString();

                default:
                    string[] URLKey = arrayURLAndKeys[1].Split('=');
                    string[] parametrKey = parametr.Split('='); 

                    if(URLKey[0] == parametrKey[0])
                    {
                        tmp.Append(parametrKey[0] + "=" + parametrKey[1]).Replace(" ","");
                        return tmp.ToString();
                    }
                    else
                    {
                        for (int i = 1; i < arrayURLAndKeys.Length; i++)
                        {
                            if (i > 1) tmp.Append("&");
                            tmp.Append(arrayURLAndKeys[i].Replace(" ", ""));
                        }
                        tmp.Append("&" + parametr.Replace(" ", ""));
                        return tmp.ToString();
                    }  
            }      
        }
    }
}
