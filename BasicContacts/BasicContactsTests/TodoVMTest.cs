using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BasicContactsTests
{
    [TestClass]
    public class TodoVMTest
    {
        [TestMethod]
        public void AddTodoReallyAddsAnItem()
        {
            var VM = new BasicContacts.TodoVM();
            Assert.AreEqual(0, VM.List.Count);
            VM.Text = "Test";
            VM.AddCommand.Execute(null);
            Assert.AreEqual(1, VM.List.Count);
            Assert.AreEqual("Test", VM.List.First());
            Assert.AreEqual(null, VM.Text);
        }
    }
}
