using System;
namespace TreeProject
{
    public interface ITree
    {
        void GrowTrunk();
        void GrowBranches();
        void NewBranch();
        void Ouch(int n);
        string Description();
    }
}
