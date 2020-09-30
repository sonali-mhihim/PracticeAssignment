using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAssignment
{
    public static class LongestCommonPrefixHelper
    {
        internal class TrieNode
        {
            private Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();

            internal bool isWord { get; private set; }

            internal int ChildrenCount { get { return this.children.Count; } }

            public void MarkAsWord()
            {
                this.isWord = true;
            }

            public TrieNode GetChildren(char ch)
            {
                if (this.children.ContainsKey(ch))
                {
                    return this.children[ch];
                }
                else
                {
                    return null;
                }
            }

            public void AddChildren(char ch)
            {
                var trieNode = new TrieNode();
                this.children.Add(ch, trieNode);
            }

            public TrieNode GetFirstChild()
            {
                return this.children.Values.GetEnumerator().Current;
            }
        }

        internal class Trie
        {
            private TrieNode root = new TrieNode();

            public void Insert(string str)
            {
                var temp = root;
                for (var i = 0; i < str.Length; i++)
                {
                    var ch = str[i];
                    var trieNode = temp.GetChildren(ch);
                    if (trieNode == null)
                    {
                        trieNode.AddChildren(ch);
                        temp = temp.GetChildren(ch);
                    }
                    else
                    {
                        temp = trieNode;
                    }
                }

                temp.MarkAsWord();
            }

            public int GetLongestPrefixLength()
            {
                var count = 0;
                var temp = root;
                while (temp.ChildrenCount == 1 && temp.isWord == false)
                {
                    count++;
                    temp = temp.GetFirstChild();
                }
                return count;
            }
        }

        public static int FindLongestCommonPrefix(List<string> input)
        {
            var trie = new Trie();
            foreach (var str in input)
            {
                trie.Insert(str);
            }
            return trie.GetLongestPrefixLength();
        }
    }
}
