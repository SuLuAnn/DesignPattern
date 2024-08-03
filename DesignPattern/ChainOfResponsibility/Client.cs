namespace DesignPattern.ChainOfResponsibility
{
    public class Client
    {
        public void Main()
        {
            IHandler customerComplaintCoR = new GeneralHandler();
            customerComplaintCoR
                .SetNext(new AsiaCustomerHandler())
                .SetNext(new EngineerCustomerHandler());

            var request1 = new CustomerComplaintTask()
            {
                Lv = 1,
                Region = "US",
                Type = "Low",
                Description = "想退貨"
            };

            Console.WriteLine(customerComplaintCoR.Execute(request1));

            var request2 = new CustomerComplaintTask()
            {
                Lv = 3,
                Region = "Asia",
                Type = "High",
                Description = "螢幕壞了"
            };

            Console.WriteLine(customerComplaintCoR.Execute(request2));

            var request3 = new CustomerComplaintTask()
            {
                Lv = 5,
                Region = "UK",
                Type = "High",
                Description = "電腦壞了"
            };

            Console.WriteLine(customerComplaintCoR.Execute(request3));
        }
    }
}
