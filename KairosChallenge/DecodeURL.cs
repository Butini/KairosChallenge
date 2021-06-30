using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KairosChallenge
{
    class Code
    {
        public int Number { get; set; }
        public char Letter { get; set; }

        public Code(int num, char lett)
        {
            Number = num;
            Letter = lett;
        }
    }
    class DecodeURL
    {
        private static readonly String Message;
        private static readonly int[] Numbers;

        private List<Code> CodeList;

        public String URL;

        static DecodeURL()
        {
            Message = "Cómo será dar con Nekgikis V...";
            Numbers = new int[] { 23, 24, 25, 18, 19, 5, 6, 7, 20, 15, 17, 8, 10, 11, 4, 3,
            12, 2, 16, 14, 9, 21, 0, 1, 13, 22
            };
        }

        public DecodeURL()
        {
            string NewMessage = ConvertAllInMinuscule(Message);

            NewCodeList(NewMessage, Numbers);

            CodeList = CodeList.OrderBy(x => x.Number).ToList();

            URL = BuildUrl(CodeList);
        }

        private string ConvertAllInMinuscule(string message)
        {
            string result = message.Normalize(NormalizationForm.FormD);

            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            result = reg.Replace(result, "");

            result = result.Replace(" ", "");
            result = result.ToLower();

            result += "...";

            return result;
        }

        private void NewCodeList(string message, int[] numbers)
        {
            int i = 0;
            CodeList = new List<Code>();

            while(i < message.Length)
            {
                Code c = new Code(numbers[i], message[i]);

                CodeList.Add(c);

                i++;
            }
        }

        private string BuildUrl(List<Code> list)
        {
            string url = "";

            foreach (var letter in list)
            {
                url += letter.Letter;
            }

            return url;
        }
    }
}
