
```c#
public class Program
    {
        static void Main(string[] args)
        {
            //string ado = "Data Source=127.0.0.1;Initial Catalog=mobileNote;User ID=sa;Password=1";
            //使用Window驗證

            string connStr = @"server=(local);integrated security=SSPI;database=Test";
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            string cmdStr = "select * from user_profile order by user_profile_id desc";

            SqlCommand com = new SqlCommand(cmdStr, conn);

            //Console.WriteLine("--SqlDataReader--");
            //SqlDataReader sqlDR = com.ExecuteReader();
            //while (sqlDR.Read())
            //{
            //    Console.WriteLine($"{sqlDR[0]} {sqlDR[1]}");
            //}

            Console.WriteLine("--DataTable--");
            DataTable dt = new DataTable("TestTable");
            dt.Load(com.ExecuteReader());
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr[0]} {dr[1]}");
            }

            conn.Close();

            Console.ReadLine();
        }
    }
```

```c#
public class Program
    {
        static void Main(string[] args)
        {
            //string ado = "Data Source=127.0.0.1;Initial Catalog=mobileNote;User ID=sa;Password=1";
            //使用Window驗證

            string connStr = @"server=(local);integrated security=SSPI;database=Test";
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            string cmdStr = "select * from user_profile order by user_profile_id desc";

            SqlCommand com = new SqlCommand(cmdStr, conn);

            Console.WriteLine("--SqlDataReader--");
            SqlDataReader sqlDR = com.ExecuteReader();
            while (sqlDR.Read())
            {
                Console.WriteLine($"{sqlDR[0]} {sqlDR[1]}");
            }

            //Console.WriteLine("--DataTable--");
            //DataTable dt = new DataTable("TestTable");
            //dt.Load(com.ExecuteReader());
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine($"{dr[0]} {dr[1]}");
            //}

            conn.Close();

            Console.ReadLine();
        }
    }
```