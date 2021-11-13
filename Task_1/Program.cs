using System;

namespace Task_1
{
    class Program
    {
        public delegate int SubstractDelegate(int a,int b);
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string row);
        static void Main(string[] args)
        {
            AnonimusMethodShow();


        }

        static void AnonimusMethodShow()
        {
            ShowMessageDelegate md = delegate()
            {
                Console.WriteLine("Hello World!");
            };
        }

        static void ShowDelegates()
        {
            //ShowMessageDelegate showMessageDelegate = ShowMessage;
            //showMessageDelegate.Invoke();
            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            //SumDelegate sumDelegate = Sum;
            Func<int,int,int,int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            //CheckLengthDelegate checkLengthDelegate = CheckLength;
            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);
        }


        static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }



        void ShowCalTwoMethodByDelegate()
        {
            SubstractDelegate sub = SubstractThroughDelegate;
            sub += PlusThroughDelegate;
            sub -= PlusThroughDelegate;
            sub(10, 100);
        }

        static void ShowDelegateWork()
        {
            SubstractDelegate sub = SubstractThroughDelegate;
            Console.WriteLine("Результат вызова делегата 1 способ: " + sub.Invoke(20, 40));
            Console.WriteLine("Результат вызова делегата 2 способ: " + sub(12, 183));
        }

        static int SubstractThroughDelegate(int a,int b)
        {   
            Console.WriteLine(b - a);
            return b - a;
        }
        int PlusThroughDelegate(int a, int b)
        {
            Console.WriteLine(b + a);
            return b + a;
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
