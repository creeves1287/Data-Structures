using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class TrieNode
    {
        public TrieNode[] Children { get; set; }
        public bool IsEndOfWord { get; set; } = false;
        public TrieNode(int alphabetSize)
        {
            Children = new TrieNode[alphabetSize];
        }

    }
}
