namespace DesignPattern.Bridge
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class CellphoneShoppingCart : ShoppingCart
    {
        public CellphoneShoppingCart(IThirdPartyPayment thirdPartyPayment) : base(thirdPartyPayment)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override bool Payment()
        {
            if (!_thirdPartyPayment.ThirdPartyPayment())
            {
                return false;
            }

            //呼叫自己的其他服務紀錄
            return true;
        }
    }
}
