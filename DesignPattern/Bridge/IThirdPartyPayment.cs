namespace DesignPattern.Bridge
{
    /// <summary>
    /// 第三方支付介面
    /// </summary>
    public interface IThirdPartyPayment
    {
        /// <summary>
        /// 第三方支付付款
        /// </summary>
        /// <returns>是否成功</returns>
        bool ThirdPartyPayment();
    }
}
