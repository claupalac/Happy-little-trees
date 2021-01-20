using System;
using System.Collections.Generic;

namespace TreeProject
{
    public class Tree : ITree
    {
        private const int INITIAL_HEIGHT = 1;
        private const int GROW_BY_ONE = 1;
        private int trunkHeight;
        private List<Branch> myBranches;

        public Tree()
        {
            myBranches = new List<Branch>();
            trunkHeight = INITIAL_HEIGHT;
        }
        public void GrowTrunk()
        {
            trunkHeight = trunkHeight + GROW_BY_ONE;
        }

        public void NewBranch()
        {
            Branch newBranch = new Branch(trunkHeight);
            myBranches.Add(newBranch);
        }

        public void GrowBranches()
        {
            foreach (Branch aBranch in myBranches)
            {
                aBranch.GrowBranchByOne();
            }
        }
        
        public void Ouch(int n)
        {
            if(IsPositionValidated(n))
            {
                myBranches.Remove(myBranches[n-1]);
            }
        }

        public string Description()
        {
            string description = "The tree trunk is " + trunkHeight.ToString() + " "+"unit(s) tall! There are 0 branch(es)!";
            if (myBranches.Count > 0)
            {
                description = "The tree trunk is " + trunkHeight.ToString() +
                    " " + "unit(s) tall! There are " + myBranches.Count.ToString() +
                    " " + "branch(es) that have position(s): " + GetBranchProperties("position") +
                    " " + "and length(s): " + GetBranchProperties("length") + "!";
            }      
            return description;
        }

        private bool IsPositionValidated(int position)
        {
            if (position > 0 && position <= myBranches.Count)
                return true;
            else
                return false;
        }


        private string GetBranchProperties(string property)
        {
            Dictionary<string, string> AllBranchProperties = new Dictionary<string, string>();
            string allValues = null;
            foreach (Branch aBranch in myBranches)
            {
                if (allValues == null)
                {
                    allValues = GetSingleProperty(aBranch, property);
                }
                else
                {
                    allValues = allValues + "," + GetSingleProperty(aBranch, property);
                }
            }
            AllBranchProperties.Add(property, allValues);
            return AllBranchProperties[property];
        }
        private string GetSingleProperty(Branch aBranch, string property)
        {
            switch (property)
            {
                case "length":
                    return aBranch.GetLength().ToString();
                case "position":
                    return aBranch.GetPosition().ToString();
            }
            return "";
        }
    }
}
