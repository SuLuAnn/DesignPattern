
namespace DesignPattern.Strategy
{
    /// <summary>
    /// 開車
    /// </summary>
    public class Car : IPathCaculate
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="currentPoint"><inheritdoc/></param>
        /// <param name="targetPoint"><inheritdoc/></param>
        /// <returns></returns>
        public DateTime Caculate(Point currentPoint, Point targetPoint)
        {
            return new DateTime(100, 20, 30, 40, 50, 60);
        }
    }
}
