using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Assignment1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IEnumerable<string> names = new[]{"Bessie","Vashti","Frederica","Nisha","Kendall","Magdalena","Brendon","Eve","Manda","Elvera","Miquel","Tyra","Lucie","Marvella","Tracee","Ramiro","Irene","Davina","Jeromy","Siu"};

        [TestMethod]
        public void MakeListOfPeople()
        {
            var actual = names.Select(x => new Person { Name = x });
        }

        [TestMethod]
        public void NamesThatStartWithM()
        {
            var actual = names.Select(x => new Person { Name = x }).Where(x => x.Name.StartsWith("M"));
        }
        [TestMethod]
        public void NamesInUpperCase()
        {
            //I assumed that by "same list," you meant the same list as the initial list
            var actual = names.Select(x => new Person { Name = x.ToUpper() });
        }
        [TestMethod]
        public void LengthOfName()
        {
            var actual = names.Select(x => x.Length).ToArray();
        }
        [TestMethod]
        public void FirstThreeLettersOrderedByname()
        {
            var actual = names.Select(x => x.Substring(0,3)).OrderBy(x => x);
        }
    }
}
