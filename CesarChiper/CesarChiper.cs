using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarChiperLibrary
{
    public class CesarChiper
    {
        //символы русской азбуки
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public CesarChiper(int Key)
        {
            this.Key = Key;
        }
        public int Key { get; set; }
        private string CodeEncode(string text, int key)
        {
            //добавляем в алфавит маленькие буквы
            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + key) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }

        //шифрование текста
        public string Encrypt(string plainMessage)
            => CodeEncode(plainMessage, Key);

        //дешифрование текста
        public string Decrypt(string encryptedMessage)
            => CodeEncode(encryptedMessage, -Key);
    }
}
