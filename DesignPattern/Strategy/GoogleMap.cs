namespace DesignPattern.Strategy
{
    public class GoogleMap
    {
        private IPathCaculate _pathCaculate;

        /// <summary>
        /// 選擇策略
        /// </summary>
        /// <param name="pathCaculate"></param>
        public void ChoiseStrategy(IPathCaculate pathCaculate)
        {
            _pathCaculate = pathCaculate;
        }

        /// <summary>
        /// 計算兩點所需時間
        /// </summary>
        /// <param name="currentPoint">所在位置</param>
        /// <param name="targetPoint">目的地</param>
        /// <returns></returns>
        public DateTime Caculate(Point currentPoint, Point targetPoint)
        {
            return _pathCaculate.Caculate(currentPoint, targetPoint);
        }
    }
}
