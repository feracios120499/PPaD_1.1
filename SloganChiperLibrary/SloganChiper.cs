using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloganChiperLibrary
{
    public class SloganCipher
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string table;
        public SloganCipher(string slogan)
        {
            this.Slogan = slogan ?? throw new ArgumentNullException("slogan");
            CreateTable();
        }

        public string Slogan
        {
            get;
            private set;
        }

        public string Encrypt(string plainMessage)
        {
            
            if (string.IsNullOrEmpty(plainMessage)) return string.Empty;
            plainMessage = plainMessage.ToUpper();
            string resultStr = string.Empty;
            foreach (var letter in plainMessage)
            {
                var index = alfabet.IndexOf(letter);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    resultStr += letter.ToString();
                }
                else
                {
                    resultStr += table[index];
                }

            }
            return resultStr;
        }

        public string Decrypt(string encryptedMessage)
        {
            if (string.IsNullOrEmpty(encryptedMessage)) return string.Empty;
            encryptedMessage = encryptedMessage.ToUpper();
            string resultStr = string.Empty;
            foreach (var letter in encryptedMessage)
            {
                var index = table.IndexOf(letter);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    resultStr += letter.ToString();
                }
                else
                {
                    resultStr += alfabet[index];
                }

            }
            return resultStr;
        }

        private void CreateTable()
        {
            table = String.Concat(Slogan.ToUpper().Where(IsRussianLetter).Distinct().Concat(alfabet.Except(Slogan.ToUpper())));
          
        }
        private bool IsRussianLetter(char character)
        {
            return char.IsLetter(character) && character >= 'A' && character <= 'я';
        }
    }
}
