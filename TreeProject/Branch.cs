using System;
namespace TreeProject
{
    public class Branch
    {
        private const int INIT_LENGTH = 1;
        private int length;
        private int position;

        public Branch(int positionCreated)
        {
            position = positionCreated;
            length = INIT_LENGTH;
        }
        public void GrowBranchByOne()
        {
            length++;
        }
        public int GetPosition()
        {
            return position;
        }
        public int GetLength()
        {
            return length;
        }
    }
}
