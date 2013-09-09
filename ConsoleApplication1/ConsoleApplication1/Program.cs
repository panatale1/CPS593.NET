

using System.Collections.Generic;
using System.Net.Http;
namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("What is your username?");
            string response = System.Console.ReadLine();
           
            System.Console.WriteLine("Here's your profile info");
            System.Console.Write(GetProfile(response));
            System.Console.ReadLine();
        }
        public static string GetProfile(string username)
        {
            var client = new HttpClient();
            var json = client.GetStringAsync("http://graph.facebook.com/" + username).Result;
            return json;
        }
    }

    public delegate int Multiply(int x, int y);

    public class Dog{
        private string _DogsWord = "woof";
        private List<string> _ListOfWords = new List<string>();
        public string DogsWord
        {
            get { return _DogsWord; }
            set { _DogsWord = value; }
        }
     
        
        public string Bark()
        {
            return _DogsWord + string.Join(", ", _ListOfWords);
        }
        public void LearnNewWord(string word)
        {
            _ListOfWords.Add(word);
        }
        public string Run()
        {
            return "I am running at " + Speed + " miles per hour.";
        }

        public string Speed { get; set; }
    }
}
