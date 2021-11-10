using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new Exception();
            ex.Data.Add("дата создания исключения:",DateTime.Now);
        }
    }
}
