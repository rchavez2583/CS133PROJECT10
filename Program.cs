using System;

namespace CS133PROJECT10
{
    class Program
    {
        public delegate void MyDelegatePointer(int a, int b);

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            MyDelegatePointer pointer;
            pointer = myClass.MyFirstMethod;

            Action<int, int> pointer2;
            pointer2 = myClass.MySecondMethod;

            Action<int, int> pointer3;
            pointer3 = myClass.MyThirdMethod;
                


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            pointer(43, 21);

        }
    }
}
public class MyClass
{
    public void MyFirstMethod(int a, int b)
    {
        Console.WriteLine(a * a * b);
    }

    public void MySecondMethod(int a, int b)
    {
        Console.WriteLine(b * b * b / a);
    }

    public void MyThirdMethod(int a, int b)
    {
        Console.WriteLine(a + b * b / a);
    }
}
