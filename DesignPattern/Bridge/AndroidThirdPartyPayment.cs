namespace DesignPattern.Bridge
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class AndroidThirdPartyPayment : IThirdPartyPayment
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool ThirdPartyPayment()
        {
            Console.WriteLine("安卓支付成功");
            return true;
        }
    }
}
