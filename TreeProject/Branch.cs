using System;
namespace TreeProject
{
    public class Branch
    {
        private const int INIT_LENGH = 1;
        private int length;
        private int position;

        public Branch(int positionCreated)
        {
            position = positionCreated;
            length = INIT_LENGH;
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
