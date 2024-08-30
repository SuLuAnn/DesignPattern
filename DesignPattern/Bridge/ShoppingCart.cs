namespace DesignPattern.Bridge
{
    /// <summary>
    /// 購物車
    /// </summary>
    public abstract class ShoppingCart
    {
        /// <summary>
        /// 第三方付款工具
        /// </summary>
        protected readonly IThirdPartyPayment _thirdPartyPayment;

        public ShoppingCart(IThirdPartyPayment thirdPartyPayment)
        {
            _thirdPartyPayment = thirdPartyPayment;
        }



        /// <summary>
        /// 使用者付款購買購物車裡的所有物品
        /// </summary>
        /// <returns>是否購買成功</returns>
        public abstract bool Payment();
    }
}