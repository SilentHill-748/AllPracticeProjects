using System;
using System.Linq;

using PasswordTaker.Services.Interfaces;

namespace PasswordTaker.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly string _secureWord;
        private readonly string _targetString;


        public PasswordService(string targetString)
        {
            _targetString = targetString;
            _secureWord = "silent";
        }


        public string SecureWord
        {
            get
            {
                return _secureWord;
            }
        }

        public string TargetString
        {
            get 
            { 
                return _targetString; 
            }
        }


        public string BuildPassword()
        {
            int targetLength = TargetString.Length;

            char lastChar = TargetString.ToUpper().Last();

            string transformedSecureWord = TransformSecureWord();

            string password = $"{targetLength + 29}{lastChar}{transformedSecureWord}{targetLength}";

            return password;
        }

        // Трансформирует защитное слово, путем удаления из него тех символов, которые есть в целевой строке.
        // В конце конкатенация из результата и его реверса.
        private string TransformSecureWord()
        {
            string secureWord = SecureWord;
            char[] chars = TargetString.ToCharArray();

            // remove all exists chars of TargetString from SecureWord
            // microsoft | testword => ewd
            for (int i = 0; i < chars.Length; i++)
                secureWord = secureWord.Replace($"{chars[i]}", "");
            
            if (secureWord.Length == 0)
                return secureWord;

            return secureWord + string.Join("", secureWord.Reverse());
        }
    }
}
