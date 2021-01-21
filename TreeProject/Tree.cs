using System;
using System.Collections.Generic;

namespace TreeProject
{
    public class Tree : ITree
    {
        private const int INIT_HEIGHT = 1;
        private const int GROW_BY_ONE = 1;
        private List<Branch> myBranches;
        private int trunkHeight;

        public Tree()
        {
            myBranches = new List<Branch>();
            trunkHeight = INIT_HEIGHT;
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
                List<int> positions = getBranchesPositionList();
                String positionsCommaSeparated = GetStringWithComas(positions);
                List<int> lengths = getBranchesLengthList();
                String lenghtsCommaSeparated = GetStringWithComas(lengths);
                description = string.Format(getDescriptionFormat(),trunkHeight,myBranches.Count,positionsCommaSeparated,lenghtsCommaSeparated);
            }      
            return description;
        }

        private string getDescriptionFormat()
        {
            return "The tree trink is {0} " +
                    "unit(s) tall! There are {1} branch(es) that have " +
                    "position(s): {2} and length(s): {3}!";
        }

        private bool IsPositionValidated(int position)
        {
            return position > 0 && position <= myBranches.Count;
        }

        private List<int> getBranchesLengthList()
        {
            List<int> lenghtList = new List<int>();
            foreach(Branch aBranch in myBranches)
            {
                lenghtList.Add(aBranch.GetLength());
            }
            return lenghtList;
        }

        private List<int> getBranchesPositionList()
        {
            List<int> lenghtList = new List<int>();
            foreach (Branch aBranch in myBranches)
            {
                lenghtList.Add(aBranch.GetPosition());
            }
            return lenghtList;
        }

        private string GetStringWithComas(List<int> rawList)
        {
            string stringWithComas = null;
            foreach(int aElement in rawList)
            {
                if (stringWithComas == null)
                    stringWithComas = aElement.ToString();
                else
                    stringWithComas = stringWithComas + "," + aElement.ToString();
            }
            return stringWithComas;
        }

    }
}
