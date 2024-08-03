namespace DesignPattern.ChainOfResponsibility
{
    public class EngineerCustomerHandler : BaseHandler
    {
        public override string Execute(CustomerComplaintTask memberInfo)
        {
            if (memberInfo.Type == "High")
            {
                return "技術工程師已承接該客訴";
            }

            if (_nextHandler != null)
            {
                return _nextHandler.Execute(memberInfo);
            }

            return "該客訴無法處理";
        }
    }
}
