namespace DesignPattern.Flyweight
{
    public class OriginalTree
    {
        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Size { get; set; }

        // 根據 x, y, size 畫出樹
        public void Draw()
        {
        }
    }
}
