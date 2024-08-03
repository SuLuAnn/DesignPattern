namespace DesignPattern.ChainOfResponsibility
{
    public interface IHandler
    {
        /// <summary>
        /// 回傳 IHandler 非必要，只是設定下一步的時候想容易點
        /// </summary>
        /// <param name="nextHandler"></param>
        /// <returns></returns>
        IHandler SetNext(IHandler nextHandler);

        string Execute(CustomerComplaintTask memberInfo);
    }
}
