
Struct & Class
```c#
namespace CMDTEST
{
    class Program
    {
        public class TestClass {
            public int Test;
        }

        public struct TestStruct
        {
            public int Test;
        }

        static void Main(string[] args)
        {
            TestClass TC1 = new TestClass();
            TC1.Test = 10;

            TestClass TC2 = TC1;
            TC2.Test = 20;

            Console.WriteLine($"TC1.Test：{TC1.Test}");

            TestStruct TS1;
            TS1.Test = 10;

            TestStruct TS2 = TS1;
            TS2.Test = 20;

            Console.WriteLine($"TS1.Test：{TS1.Test}");

            Console.ReadLine();
        }
    }
}

```

```c#
namespace Class_Demo
{
    public class TestClass
    {
        public int Test;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass TC1 = new TestClass();
            TC1.Test = 10;

            TestClass TC2 = TC1;
            TC2.Test = 20;

            Console.WriteLine($"TC1.Test:{TC1.Test}");
            Console.ReadLine();
        }
    }
}
```

```c#
namespace Struct
{
    public struct TestStruct
    {
        public int Test;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestStruct TS1;
            TS1.Test = 10;

            TestStruct TS2 = TS1;
            TS1.Test = 20;

            Console.WriteLine($"TS2.Test：{TS2.Test}");
            Console.ReadLine();
        }
    }
}
```

```c#
namespace List_Capacity
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            Console.WriteLine("初始狀態");
            Console.WriteLine($"Count:{intList.Count}");
            Console.WriteLine($"Capacity:{intList.Capacity}");
            Console.ReadLine();

            intList.Add(1);
            Console.WriteLine("新增一個元素");
            Console.WriteLine($"Count:{intList.Count}");
            Console.WriteLine($"Capacity:{intList.Capacity}");
            Console.ReadLine();

            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            Console.WriteLine("新增四個元素");
            Console.WriteLine($"Count:{intList.Count}");
            Console.WriteLine($"Capacity:{intList.Capacity}");
            Console.ReadLine();

            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            intList.Add(9);
            intList.Add(10);

            Console.WriteLine("新增五個元素");
            Console.WriteLine($"Capacity:{intList.Count}");
            Console.WriteLine($"Capacity:{intList.Capacity}");
            Console.ReadLine();

            intList.Clear();

            Console.WriteLine("清除集合");
            Console.WriteLine($"Count:{intList.Count}");
            Console.WriteLine($"Capacity:{intList.Capacity}");

            Console.ReadLine();
        }
    }
}
```

```c#
class Program
    {
        static void CallByValue(int Fun_Test)
        {
            Fun_Test++;
        }

        static void CallByRef(ref int Fun_Test)
        {
            Fun_Test++;
        }

        static void CallByOut(out int Fun_Test)
        {
            Fun_Test = 0;
            Fun_Test++;
        }

        static void Main(string[] args)
        {
            int MainTest = 0;

            CallByValue(MainTest);
            Console.WriteLine(MainTest);

            CallByRef(ref MainTest);
            Console.WriteLine(MainTest);
            Console.ReadLine();

            int MainOutTest;
            CallByOut(out MainOutTest);
            Console.WriteLine(MainOutTest);
            Console.ReadLine();
        }
    }
```

```c#
namespace DelegatePractice
{
     public class Program
     {
        public delegate void DelegateTestParameter(string text);
        public delegate string DelegateTestReturnString();

        static void Main(string[] args)
        {
            //NoReturn
            DelegateTestParameter DTP = new DelegateTestParameter(Show);
            DTP.Invoke("Hello!!DelegateWithInvoke");
            DTP("Hello!!Delegate");
            
            //ReturnString
            DelegateTestReturnString DTRS = new DelegateTestReturnString(ReturnStringShow);
            Console.WriteLine(DTRS());
            Console.ReadLine();
        }

        static void Show(string fun_text)
        {
            Console.WriteLine(fun_text);
        }

        static string ReturnStringShow() {
            return "Hello!!ReturnDelegate";
        }
    }
}
```