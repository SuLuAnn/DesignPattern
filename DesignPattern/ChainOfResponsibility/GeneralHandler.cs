namespace DesignPattern.ChainOfResponsibility
{
    public class GeneralHandler : BaseHandler
    {
        public override string Execute(CustomerComplaintTask memberInfo)
        {
            if (memberInfo.Lv < 1 || memberInfo.Type == "Low")
            {
                return "一線客服人員已承接該客訴";
            }

            if (_nextHandler != null)
            {
                return _nextHandler.Execute(memberInfo);
            }

            return "該客訴無法處理";
        }
    }
}
