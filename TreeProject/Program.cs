using System;

namespace TreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.NewBranch();
            myTree.NewBranch();
            myTree.GrowTrunk();
            myTree.GrowBranches();
            myTree.NewBranch();
            Console.WriteLine(myTree.Description());
        }
    }
}
