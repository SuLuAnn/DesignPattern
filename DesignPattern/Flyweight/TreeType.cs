namespace DesignPattern.Flyweight
{
    public class TreeType
    {
        public TreeType(string imgUrl)
        {
            Name = "Tree";
            ImgUrl = imgUrl;
        }

        public string Name { get; set; }

        public string ImgUrl { get; set; }
    }
}
