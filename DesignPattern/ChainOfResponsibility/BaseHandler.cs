namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 基礎處理方法，非必要
    /// </summary>
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public abstract string Execute(CustomerComplaintTask memberInfo);

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }
    }
}
