namespace DesignPattern.Flyweight
{
    public class Tree
    {
        public Tree(int x, int y, int size, TreeType treeType)
        {
            X = x;
            Y = y;
            Size = size;
            TreeType = treeType;
        }

        public TreeType TreeType { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Size { get; set; }

        // 根據 x, y, size 畫出樹
        public void Draw()
        {
        }
    }
}
