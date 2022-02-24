using System;

namespace MetanitConsoleApp
{
    class Game : GameLogic
    {
        private readonly Random rand = new Random();
        private string UserKey { get; set; }
        private string SecretNum { get; set; }

        public Game() { }

        /// <summary>
        /// Generates a new game with a new hidden number.
        /// </summary>
        public void NewGame()
        {
            SecretNum = SetSecretNum();

            while (true)
            {

                UserKey = SetUserKey();

                Logic(SecretNum, UserKey, out int cows, out int bulls);

                Console.WriteLine($"\nЧисло коров: {cows}.     Число быков: {bulls}.");

                if (cows == 4)
                {
                    Console.Write("Победа.\n");
                    break;
                }
                else
                {
                    Console.Write("Попробуй еще.\n");
                }
            }
        }

        /// <summary>
        /// Generation new random number.
        /// </summary>
        /// <returns> Generated new SecretNumber. </returns>
        private string SetSecretNum()
        {
            string secret = rand.Next(0, 10000).ToString();

            while (secret.Length < 4)
            {
                secret = "0" + secret;
            }

            return secret;
        }

        /// <summary>
        /// User enter your number.
        /// </summary>
        /// <returns> New user number. </returns>
        private string SetUserKey()
        {
            string userKey;

            Console.WriteLine("\nВведите четырехзначное число: ");
            while (true)
            {
                userKey = Console.ReadLine();

                if(int.TryParse(userKey, out int result))
                {
                    if (userKey.Length == 4)
                    {
                        break;
                    }
                }
            }

            return userKey;
        }
    }
}
