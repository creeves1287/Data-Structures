using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tries;

namespace TrieTests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void TrieTest()
        {
            ITrie trie = new Trie();
            RunTests(trie);
        }

        private void RunTests(ITrie trie)
        {
            TestInsertAndSearch(trie);
        }

        private void TestInsertAndSearch(ITrie trie)
        {
            string a = "hello";
            string b = "hell";
            string c = "there";
            trie.Insert(a);
            trie.Insert(b);
            trie.Insert(c);
            Search(trie, a, true);
            Search(trie, b, true);
            Search(trie, c, true);
            Search(trie, "does not exist", false);
        }

        private void Search(ITrie trie, string s, bool expected)
        {
            bool result = trie.Search(s);
            Assert.AreEqual(expected, result);
        }
    }
}
