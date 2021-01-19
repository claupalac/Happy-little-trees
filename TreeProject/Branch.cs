using System;
namespace TreeProject
{
    public class Branch
    {
        private int lengtht;
        private int position;

        public Branch(int positionCreated)
        {
            position = positionCreated;
            lengtht = 1;
        }
        public void GrowBranchByOne()
        {
            lengtht++;
        }
        public int GetPosition()
        {
            return position;
        }
        public int GetLenght()
        {
            return lengtht;
        }
    }
}
