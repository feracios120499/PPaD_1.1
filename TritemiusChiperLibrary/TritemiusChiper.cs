using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TritemiusChiperLibrary
{
    public class TritemiusChiper
    {
        char[,] square;
        string alphabet;

        public TritemiusChiper(string alphabet = null)
        {
            this.alphabet = alphabet ?? "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
        }

        //возвращает квадрат
        char[,] GetSquare(string key)
        {
            var newAlphabet = alphabet;
            //удаляем из алфавита все символы которые содержит ключ
            for (int i = 0; i < key.Length; i++)
            {
                newAlphabet = newAlphabet.Replace(key[i].ToString(), "");
            }

            //добавляем пароль в начало алфавита, а в конец дополнительные знаки
            //для того чтобы избежать пустых ячеек
            newAlphabet = key + newAlphabet + "0123456789!@#$%^&*)_+-=<>?,.";

            //получаем размер стороны квадрата
            //округлением квадратного корня в сторону большего целого числа
            var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

            //создаем и заполняем массив
            square = new char[n, n];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index < newAlphabet.Length)
                    {
                        square[i, j] = newAlphabet[index];
                        index++;
                    }
                }
            }

            return square;
        }

        //поиск символа в двухмерном массиве
        bool FindSymbol(char[,] symbolsTable, char symbol, out int column, out int row)
        {
            var l = symbolsTable.GetUpperBound(0) + 1;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (symbolsTable[i, j] == symbol)
                    {
                        //значение найдено
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }

            //если ничего не нашли
            row = -1;
            column = -1;
            return false;
        }

        public string Encrypt(string text, string password)
        {
            var outputText = "";
            var square = GetSquare(password.ToUpper());
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    var newRowIndex = rowIndex == square.GetUpperBound(1)
                        ? 0
                        : rowIndex + 1;
                    outputText += square[newRowIndex, columnIndex].ToString();
                }
            }
            return outputText;
        }

        public string Decrypt(string text, string password)
        {
            var outputText = "";
            var square = GetSquare(password.ToUpper());
            text = text.ToUpper();
            var m = text.Length;

            for (int i = 0; i < m; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    var newRowIndex = rowIndex == 0
                        ? square.GetUpperBound(1)
                        : rowIndex - 1;
                    outputText += square[newRowIndex, columnIndex].ToString();
                }
            }

            return outputText;
        }
    }
}
