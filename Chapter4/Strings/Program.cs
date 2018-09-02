using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3] {1, 2, 3};
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            var firstName = "Harry";
            var lastName = "Wu";
            var fullName = firstName + " " + lastName;
            var fullName2 = string.Format("My full name is {0} {1}", firstName, lastName);
            var names = new string[3] {"John", "Jack", "Mary"};
            var joinedName = string.Join(" and ", names);
            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(joinedName);

            var text = @"		2018/4/10 星期二			所有用户(A)
5E对战平台2.0	杭州易玩科技有限公司	2018/2/7 星期三	62.4 MB	2.1.29	Administrator
ACDSee Photo Studio Ultimate 2018	ACD Systems International Inc.	2018/4/3 星期二	666 MB	11.2.0.1309	所有用户(A)
Adblock Plus for IE (32 位和 64 位)	Eyeo GmbH	2017/7/13 星期四	14.1 MB	1.6	所有用户(A)
Adobe Acrobat Reader DC - Chinese Simplified	Adobe Systems Incorporated	2018/4/1 星期日	574 MB	18.011.20038 所有用户(A)
Adobe Acrobat XI Pro	Adobe Systems	2017/8/22 星期二	1.40 GB	11.0.00	所有用户(A)";
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
