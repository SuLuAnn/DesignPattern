namespace DesignPattern.Strategy
{
    /// <summary>
    /// 走路
    /// </summary>
    public class Foot : IPathCaculate
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="currentPoint"><inheritdoc/></param>
        /// <param name="targetPoint"><inheritdoc/></param>
        /// <returns></returns>
        public DateTime Caculate(Point currentPoint, Point targetPoint)
        {
            return new DateTime(10, 2, 3, 4, 5, 6);
        }
    }
}
