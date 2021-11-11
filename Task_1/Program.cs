using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowRankException();
        }

        static void FillDataExeption()
        {
            Exception ex = new Exception("Исключение");
            ex.Data.Add("дата создания исключения:", DateTime.Now);
            ex.HelpLink = "www.msnd.com";
        }

        static void ShowArgumentOutOfRangeException()
        {
            try
            {
                Console.WriteLine("Блок try сработал");
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace.ToString());
            }
            finally
            {
                Console.WriteLine("Блок finaly сработал");
            }
        }

        static void ShowRankException()
        {
            try
            {
                Console.WriteLine("Блок try сработал");
                throw new RankException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace.ToString());
            }
            finally
            {
                Console.WriteLine("Блок finaly сработал");
            }
        }
    }
}
