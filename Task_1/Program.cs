using System;

namespace Task_1
{
    class Program
    {
        public delegate int SubstractDelegate(int a,int b);
        static void Main(string[] args)
        {
            ShowDelegateWork();

        }

        static void ShowDelegateWork()
        {
            SubstractDelegate sub = SubstractThroughDelegate;
            Console.WriteLine("Результат вызова делегата 1 способ: " + sub.Invoke(20, 40));
            Console.WriteLine("Результат вызова делегата 2 способ: " + sub(12, 183));
        }

        static int SubstractThroughDelegate(int a,int b)
        {
            return b - a;
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
