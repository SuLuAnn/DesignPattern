namespace DesignPattern.Bridge
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    internal class IOSThirdPartyPayment : IThirdPartyPayment
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool ThirdPartyPayment()
        {
            Console.WriteLine("iOS 支付成功");
            return true;
        }
    }
}
