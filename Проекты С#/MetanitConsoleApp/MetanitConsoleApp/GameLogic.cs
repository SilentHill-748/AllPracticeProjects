

namespace MetanitConsoleApp
{
    class GameLogic
    {
        protected void Logic(string secret, string key, out int cows, out int bulls)
        {
            int countCows = 0;
            int countBulls = 0;

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] != key[i])
                {
                    for (var j = 0; j < key.Length; j++)
                    {
                        if (secret[i] == key[j] && i != j)
                        {
                            countBulls++;
                            Replace(ref key, j, '-');
                            break;
                        }
                    }
                }
                else
                {
                    countCows++;
                    Replace(ref secret, i, '-');
                    Replace(ref key, i, '-');
                }
            }

            cows = countCows;
            bulls = countBulls;
        }

        /// <summary>
        /// Replaces a character with a new one at index.
        /// </summary>
        private void Replace(ref string str, int index, char newCharacter)
        {
            char[] newStr = str.ToCharArray();
            str = "";
            newStr[index] = newCharacter;

            for (var i = 0; i < newStr.Length; i++)
            {
                str += newStr[i];
            }
        }
    }
}
