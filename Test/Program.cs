using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch1 = new Stopwatch();

            watch1 = new Stopwatch();
            watch1.Start();

            #region Helps


            new TestCompress().Test();
            #endregion


            Console.WriteLine("测试方法运行时间：" + watch1.Elapsed);
            Console.Read();
        }
    }
}
