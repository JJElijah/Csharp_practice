
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

```c#
static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 1; i <= 50000; i++)
            {
                list.Add(i);
            }
            sw.Stop();

            Console.WriteLine($"Spend Time:{sw.Elapsed}");

            Console.ReadLine();

            sw.Reset();
            List<int> intList = new List<int>();
            sw.Start();
            for (int i = 1; i <= 50000; i++)
            {
                intList.Add(i);
            }
            sw.Stop();
            Console.WriteLine($"Spend Time:{sw.Elapsed}");

            Console.ReadLine();
        }
```

```c#
static void Main(string[] args)
        {
            List<int> intList1 = new List<int>();
            intList1.Add(1);
            intList1.Add(2);
            intList1.Add(3);

            List<int> intList2 = new List<int>(intList1);
            intList1[0] = 100;

            Console.WriteLine($"intList2[0]:{intList2[0]}");
            Console.ReadLine();
        }

static void Main(string[] args)
        {
            List<TestClass> list1 = new List<TestClass>();
            list1.Add(new TestClass(){
                Test = 1
            });

            list1.Add(new TestClass()
            {
                Test = 2
            });

            List<TestClass> list2 = new List<TestClass>(list1);
            Console.WriteLine($"list2.Count:{list2.Count}");
            list1.Clear();

            Console.WriteLine($"list1.Count:{list1.Count}");
            Console.WriteLine($"list2.Count:{list2.Count}");

            Console.ReadLine();
        }
```

序列化
```c#
[Serializable]
    public class TestClass
    {
        public int Test1;
        public int Test2;
        public string TestStr;
    }

    class Program
    {
        static private TestClass _TC1 = new TestClass() {
            Test1 = 10,
            Test2 = 20,
            TestStr = "TC1"
        };

        static private TestClass _TC_Clone = new TestClass();

        static private IFormatter _formatter = new BinaryFormatter();

        static void SeriableMethod() {
            using (Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                _formatter.Serialize(stream, _TC1);
                stream.Close();
            }
        }

        static void DeSeriableMethod()
        {
            using (Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                _TC_Clone =  (TestClass)_formatter.Deserialize(stream);
                stream.Close();
            }
        }

        static void Main(string[] args)
        {
            SeriableMethod();
            DeSeriableMethod();

            Console.WriteLine(_TC_Clone.Test1);
            Console.WriteLine(_TC_Clone.Test2);
            Console.WriteLine(_TC_Clone.TestStr);
            Console.ReadLine();

            Console.WriteLine("修改TC1");
            _TC1.Test1 = 100;
            _TC1.Test2 = 200;

            Console.WriteLine(_TC_Clone.Test1);
            Console.WriteLine(_TC_Clone.Test2);
            Console.WriteLine(_TC_Clone.TestStr);
            Console.ReadLine();

        }
    }
```