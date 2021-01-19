using System;
using System.Collections.Generic;

namespace TreeProject
{
    public class Tree : ITree
    {
        private int trunkHeight;
        private List<Branch> myBranches = new List<Branch>();

        public Tree()
        {
            trunkHeight = 1;
        }
        public void GrowTrunk()
        {
            trunkHeight = trunkHeight + 1;
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
        private int BranchesCount()
        {
            int result = 0;
            foreach(Branch aBranch in myBranches)
            {
                result = result + 1;
            }
            return result;
        }
        public void Ouch(int n)
        {
            if(ValidatePosition(n))
            {
                myBranches.Remove(myBranches[n-1]);
            }
        }

        public string Description()
        {
            string description = "The tree trunk is " + trunkHeight.ToString() + " "+"unit(s) tall! There are 0 branch(es)!";
            if (BranchesCount() > 0)
            {
                description = "The tree trunk is " + trunkHeight.ToString() +
                    " " + "unit(s) tall! There are " + Convert.ToString(BranchesCount()) +
                    " " + "branch(es) that have position(s): " + StringOfBranchesPositions() +
                    " " + "and length(s): " + StringOfBranchesLenght() + "!";
            }      
            return description;
        }

        private bool ValidatePosition(int position)
        {
            if (position > 0 && position < myBranches.Count) return true;
            else return false;
        }
        private string StringOfBranchesPositions()
        {
            string allPositions = null;
            foreach(Branch aBranch in myBranches)
            {
                if(allPositions==null)
                {
                    allPositions = aBranch.GetPosition().ToString();
                }
                else
                {
                    int position = aBranch.GetPosition();
                    allPositions = allPositions + "," + Convert.ToString(position);
                }
                
            }
            return allPositions;
        }
        private string StringOfBranchesLenght()
        {
            string allLenghts = null;
            foreach (Branch aBranch in myBranches)
            {
                if (allLenghts == null)
                {
                    allLenghts = aBranch.GetLenght().ToString();
                }
                else
                {
                    int lenghts = aBranch.GetLenght();
                    allLenghts = allLenghts + "," + Convert.ToString(lenghts);
                }      
            }
            return allLenghts;
        }
    }
}
