namespace DesignPattern.Bridge
{
    public class BridgeProgram
    {
        public void Main()
        {
            ShoppingCart shoppingCart = new CellphoneShoppingCart(new IOSThirdPartyPayment());
            shoppingCart.Payment();
        }
    }
}
