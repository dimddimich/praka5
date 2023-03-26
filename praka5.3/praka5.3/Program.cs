using System.Text.RegularExpressions;

namespace praka5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }

    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            return Regex.Replace(textLine, @"\d", "");
        }
    }

    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            return Regex.Replace(textLine, @"[a-zA-Z]", "");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "Vladelec VAZ 2115";
            IFilter digitFilter = new DigitFilter();
            IFilter letterFilter = new LetterFilter();

            string outputText1 = digitFilter.Execute(inputText);
            string outputText2 = letterFilter.Execute(inputText);

            Console.WriteLine(outputText1);
            Console.WriteLine(outputText2);
            Console.ReadKey();
        }
    }
}
