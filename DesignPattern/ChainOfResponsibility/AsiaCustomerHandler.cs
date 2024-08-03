namespace DesignPattern.ChainOfResponsibility
{
    public class AsiaCustomerHandler : BaseHandler
    {
        public override string Execute(CustomerComplaintTask memberInfo)
        {
            if (memberInfo.Region == "Asia" || memberInfo.Type == "Mid")
            {
                return "亞洲區客服人員已承接該客訴";
            }

            if (_nextHandler != null)
            {
                return _nextHandler.Execute(memberInfo);
            }

            return "該客訴無法處理";
        }
    }
}
