using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Task2
{
    public class TitleSenten
    {
        /// <summary>
        /// Make sentenses Title
        /// </summary>
        /// <param name="sentence">Sentenses</param>
        /// <param name="exception">expception</param>
        /// <returns></returns>
        public static string ConvertToTitleSentence(string sentence, string exception = "")
        {
            StringBuilder tmp = new StringBuilder();

            string[] arrayOfWord = sentence.Split(' ');
            string[] arrayOfExp = exception.Split(' ');

            for (int i = 0; i < arrayOfWord.Length; i++)
            {
                bool chaenge = true;
                for (int j = 0; j < arrayOfExp.Length; j++)
                {
                    if (arrayOfWord[i].ToLower() == arrayOfExp[j].ToLower())
                    {
                        chaenge = false;
                        break;
                    }
                }

                if (chaenge == true || i == 0)
                {
                    arrayOfWord[i] = arrayOfWord[i].ToLower();
                    tmp.Append(arrayOfWord[i].First().ToString().ToUpper() + arrayOfWord[i].Substring(1) + " ");
                }
                else
                {
                    arrayOfWord[i] = arrayOfWord[i].ToLower();
                    tmp.Append(arrayOfWord[i] + " ");
                }
            }

            return tmp.ToString();
        }
    }
}
