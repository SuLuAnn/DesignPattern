namespace DesignPattern.Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, TreeType> _treeTypes;
        public Tree GetTree(int x, int y, int size, string imgUrl)
        {
            if (!_treeTypes.TryGetValue(imgUrl, out TreeType treeType))
            {
                treeType = new TreeType(imgUrl);
                _treeTypes.Add(imgUrl, treeType);
            }

            return new Tree(x, y, size, treeType);
        }
    }
}
