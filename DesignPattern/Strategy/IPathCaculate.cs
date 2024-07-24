namespace DesignPattern.Strategy
{
    /// <summary>
    /// 不同路線計算方法
    /// </summary>
    public interface IPathCaculate
    {
        /// <summary>
        /// 計算兩點所需時間
        /// </summary>
        /// <param name="currentPoint">所在位置</param>
        /// <param name="targetPoint">目的地</param>
        /// <returns></returns>
        DateTime Caculate(Point currentPoint, Point targetPoint);
    }
}
