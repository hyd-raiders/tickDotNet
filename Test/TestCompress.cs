using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tick.Helpers;

namespace Test
{
    public class TestCompress
    {
        public void Test() { }
        public void TestCompressGzip()
        {
            Console.WriteLine("Gzip--------------------------------------------------------------");
            string content = "我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关系了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。我是中国人，我来自苏州，我是一个件一般是从其扩展名判断其类型（但扩展名也是可以随便改的，扩展名主要告诉系统该用什么软件打开这个文件才正确），至于显示的图标就更没关了，你现在是用winrar关联打开，如果用其他软件则会显示其他图标。";
            Console.WriteLine("【文档内容】" + content);
            Console.WriteLine("【文字数量】" + content.Length);

            string inter = "H4sIAAAAAAAAAO2QTVLCQBCFz+rSjQs2bgMlJBEhUsYUJPyWhELKCDEWhkwSDmN3z7jKFWyMxQ0sN7Obev36vZ6PrAENt5BGGBSQZVV+R6xMQmVuVNfBj+mvcvIYkG5A7PmhrJeTIvrY3pP9jPEj3vfQWpIXsSJjgdNulVtQdM5TOMx4BR3eCr98B8ojuQfp35zyz55UqFUTB7dqa8tESDFT21C6axAGHCxV8C7XPWBuqOOIjyHP/FF6FD3JxWuV25ymzASyPg1Lucw4H4OS5ibuYgre6W2B7YSTIeuwE4q57O9wvObDuOX68qpx0WCDarp1C3tw1aLpmKf8LxBefQNaI8j9uqLW65ZPo0Wap+apeWqemqfmqXn+B8+/g/kNYNyJuC0JAAA=";//GzipHelper.CompressData(content);
            Console.WriteLine("【压缩后内容】" + inter);
            Console.WriteLine("【内容数量】" + inter.Length);

            GzipHelper h = new GzipHelper();
            content = h.DeCompressData(inter);
            Console.WriteLine("【解压后文档内容】" + content);
            Console.WriteLine("【解压后文字数量】" + content.Length);

            h.CompressData("D:/test.docx", "D:/test1.zip");
            h.DeCompressData("D:/test1.zip", "D:/test2.docx");

        }
    }
}
