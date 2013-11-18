using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DataLayer.Models.CSharpContext();
            var keywords = db.Keywords;
            foreach (var k in keywords)
            {
                Console.WriteLine("{0} - {1} ({2})", k.Parent.Name, k.Name, k.Id);
            }
            foreach (var c in db.Contacts)
            {
                Console.WriteLine("{0} {1} - {2}", c.FirstName, c.LastName, c.Keyword.Name);
                foreach (var item in c.ContactMethods)
                {
                    Console.WriteLine("\t -- {0} {1} ", item.Keyword.Name, item.Value);
                }
            }
            Console.WriteLine("Enter a contact in the following format (FirstName LastName Phone)");
            var results = Console.ReadLine();
            var values = results.Split();
            var contact = new DataLayer.Models.Contact { FirstName = values[0], LastName=values[1], KeywordsId = 5 };
            db.Contacts.Add(contact);
            contact.ContactMethods.Add(new DataLayer.Models.ContactMethod { KeywordId = 8, Value=values[2] });
            db.SaveChanges();

            /*
            Console.WriteLine("What is your user name?");
            var name = Console.ReadLine();
            Console.Write(GetUserInfo(name));
            Console.ReadLine();
             */
        }

        public static string GetUserInfo(string name)
        {
            var web = new HttpClient();
            return web.GetStringAsync("http://graph.facebook.com/" + name).Result;
        }
    }

    public delegate int Multiply(int x, int y);

    public class Dog
    {
        private List<string> _ListOfWords = new List<string>();
        private string _DogsWord = "woof";

        public string DogsWord
        {
            get {
                return _DogsWord;
            }
            set {
                _DogsWord = value;
            }
        }
        public string Speed { get; set; }
        
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
            return "I am running at " + Speed + " Miles an Hour";
        }

    }
}
