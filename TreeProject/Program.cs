using System;

namespace TreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.GrowTrunk();
            myTree.NewBranch();
            myTree.NewBranch();
            myTree.GrowBranches();
            myTree.NewBranch();
            myTree.GrowTrunk();
            myTree.NewBranch();
            myTree.Ouch(1);
            Console.WriteLine(myTree.Description());
        }
    }
}
