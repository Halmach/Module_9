using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new Exception("Исключение");
            ex.Data.Add("дата создания исключения:",DateTime.Now);
            ex.HelpLink = "www.msnd.com";

        }
    }
}
