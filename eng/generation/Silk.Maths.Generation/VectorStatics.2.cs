namespace Silk.Maths.Generation
{
    partial class VectorStatics
    {
        public int Dimension = 2;
        public bool FloatType = true;
        public int MinDim = 2;
        public int MaxDim = 4;
        public int MinMatRow = 2;
        public int MaxMatRow = 5;
        public int MinMatCol = 2;
        public int MaxMatCol = 4;

        public VectorStatics(int dim = 2, bool floatType = true, int minDim = 2, int maxDim = 4, int minMatRow = 2, int maxMatRow = 5, int minMatCol = 2, int maxMatCol = 4)
        {
            Dimension = dim;
            FloatType = floatType;
            MinDim = minDim;
            MaxDim = maxDim;
            MinMatRow = minMatRow;
            MaxMatRow = maxMatRow;
            MinMatCol = minMatCol;
            MaxMatCol = maxMatCol;
        }
    }
}
