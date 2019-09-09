using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoalphabeticLibrary
{
    public enum Mode
    {
        Encrypt,
        Decrypt
    }
    public class Monoalphabetic
    {
        const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ !";
        readonly Dictionary<char, char> _alphabetShuffled;
        readonly Dictionary<char, char> _alphabetShuffledReverse;

        public Monoalphabetic()
        {
            _alphabetShuffledReverse = new Dictionary<char, char>();
            _alphabetShuffled = new Dictionary<char, char>();
            ShuffleAlphabet();
        }

        public string Encrypt(string plainText)
        {
            plainText = plainText.ToUpper();
            return Process(plainText, Mode.Encrypt);
        }

        public string Decrypt(string cipherText)
        {
            cipherText = cipherText.ToUpper();
            return Process(cipherText, Mode.Decrypt);
        }
        private string Process(string token, Mode mode)
        {
            string result = "";

            for (int i = 0; i < token.Length; i++)
            {
                switch (mode)
                {
                    case Mode.Encrypt:
                        result += _alphabetShuffled[token[i]];
                        break;
                    case Mode.Decrypt:
                        result += _alphabetShuffledReverse[token[i]];
                        break;
                }
            }

            return result;
        }

        private void ShuffleAlphabet()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            var alphabetCopy = alphabet.ToList();

            foreach (var character in alphabet)
            {
                int characterPosition = r.Next(0, alphabetCopy.Count);
                char randomCharacter = alphabetCopy[characterPosition];
                _alphabetShuffled.Add(character, randomCharacter);
                _alphabetShuffledReverse.Add(randomCharacter, character);
                alphabetCopy.RemoveAt(characterPosition);
            }
        }
    }
}
