using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class Trie : ITrie
    {
        private TrieNode _root;
        private const int ALPHABET_SIZE = 26;

        public void Insert(string s)
        {
            if (_root == null)
                _root = new TrieNode(ALPHABET_SIZE);
            TrieNode node = _root;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int index = c - 'a';
                if (node.Children[index] == null)
                    node.Children[index] = new TrieNode(ALPHABET_SIZE);
                node = node.Children[index];
            }
            node.IsEndOfWord = true;
        }

        public bool Search(string s)
        {
            if (_root == null) return false;
            TrieNode node = _root;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int index = c - 'a';
                if (node.Children[index] == null)
                    return false;
                node = node.Children[index];
            }
            return node.IsEndOfWord;
        }
    }
}
