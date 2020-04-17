using System;

namespace Loops
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 10;

            /* while 循环执行 */
            while (a < 20)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
            }
            Console.ReadLine();
        }
    }
}

/*
a 的值： 10
a 的值： 11
a 的值： 12
a 的值： 13
a 的值： 14
a 的值： 15
a 的值： 16
a 的值： 17
a 的值： 18
a 的值： 19
*/

------------------------------------------------
using System;

namespace Loops
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /* for 循环执行 */
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("a 的值： {0}", a);
            }
            Console.ReadLine();
        }
    }
}
/*
a 的值： 10
a 的值： 11
a 的值： 12
a 的值： 13
a 的值： 14
a 的值： 15
a 的值： 16
a 的值： 17
a 的值： 18
a 的值： 19
*/
-------------------------------------------------------
using System;

namespace Loops
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 10;

            /* do 循环执行 */
            do
            {
               Console.WriteLine("a 的值： {0}", a);
                a = a + 1;
            } while (a < 20);

            Console.ReadLine();
        }
    }
}
/*
a 的值： 10
a 的值： 11
a 的值： 12
a 的值： 13
a 的值： 14
a 的值： 15
a 的值： 16
a 的值： 17
a 的值： 18
a 的值： 19
*/
----------------------------------------------------
using System;

namespace Loops
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 10;

            /* while 循环执行 */
            while (a < 20)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
                if (a > 15)
                {
                    /* 使用 break 语句终止 loop */
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
/*
a 的值： 10
a 的值： 11
a 的值： 12
a 的值： 13
a 的值： 14
a 的值： 15
*/
-----------------------------------------------------------
using System;

namespace Loops
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 10;

            /* do 循环执行 */
            do
            {
                if (a == 15)
                {
                    /* 跳过迭代 */
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("a 的值： {0}", a);
                a++;

            } while (a < 20);
 
            Console.ReadLine();
        }
    }
}
/*
a 的值： 10
a 的值： 11
a 的值： 12
a 的值： 13
a 的值： 14
a 的值： 16
a 的值： 17
a 的值： 18
a 的值： 19
*/
