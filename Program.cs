using System;

namespace TreesC_
{
    class Program
    {
        static void Main(string[] args)
        {
           Node rootnode = new Node();
           rootnode.Data = 4;
            BinarySearchTree.Insert(rootnode,2);
            BinarySearchTree.Insert(rootnode,5);
            BinarySearchTree.Insert(rootnode,12);
            BinarySearchTree.Insert(rootnode,100);
           System.Console.WriteLine(rootnode.Right.Data);
            
        }
        
    }
}
